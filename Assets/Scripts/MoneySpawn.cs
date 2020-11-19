using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    [Header("Префаб монетки")]
    [SerializeField] private GameObject prefabMoney;

    [Header("Первоначальная скорость монетки")]
    [SerializeField] private float speed;
    private float firstSpeed;

    [Header("На сколько % увеличивать скорость монетки со временем")]
    [SerializeField] private float enlargeSpeed = 20;

    [Header("В каких местах спавнить монетки")]
    [SerializeField] private Transform[] placeSpawn;

    [Header("Время перезарядки спавна монетки")]
    [SerializeField] private float coolDown;

    private List<GameObject> allMoneys = new List<GameObject>();
    private ManagerPool managerPool = new ManagerPool();

    [Header("Объект 'Score' ")]
    [SerializeField] private Score score = new Score();

    private static MoneySpawn instance;
    public static MoneySpawn Instance => instance;

    private void Awake()
    {
        InitializationSingleton();
        managerPool.AddPool(PoolType.Entities);
    }

    private void Start()
    {
        firstSpeed = speed;

        StartCoroutine(Spawn());
    }

    private void InitializationSingleton()
    {
        if (instance != null && instance != this) Destroy(gameObject);
        else instance = this;
    }

    /// <summary>
    /// Бесконечная корутина для создания монеток
    /// </summary>
    IEnumerator Spawn()
    {
        InitializationMoney();

        yield return new WaitForSeconds(coolDown);

        StartCoroutine(Spawn());
    }

    /// <summary>
    /// Создание и инициализация созданной монетки
    /// </summary>
    private void InitializationMoney()
    {
        int rand = Random.Range(0, placeSpawn.Length);

        allMoneys.Add(managerPool.Spawn(PoolType.Entities, prefabMoney, placeSpawn[rand].position));
        allMoneys[allMoneys.Count - 1].GetComponent<MoneyController>().speed = speed;
    }

    /// <summary>
    /// Деспавн монетки
    /// </summary>
    public void DespawnMoney(GameObject obj, bool isChest)
    {
        if (isChest)
        {
            managerPool.Despawn(PoolType.Entities, obj);

            if (score.isEnlargeSpeedMoney())
            {
                speed += (speed * enlargeSpeed) / 100f;
            }
        }
        else
        {
            managerPool.Despawn(PoolType.Entities, obj);
        }
    }
}
