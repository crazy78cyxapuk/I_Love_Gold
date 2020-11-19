﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    [Header("Префаб монетки")]
    [SerializeField] private GameObject prefabMoney;

    [Header("Первоначальная скорость монетки")]
    [SerializeField] private float speed;

    [Header("В каких местах спавнить монетки")]
    [SerializeField] private Transform[] placeSpawn;

    [Header("Время перезарядки спавна монетки")]
    [SerializeField] private float coolDown;

    private List<GameObject> allMoneys = new List<GameObject>();
    private ManagerPool managerPool = new ManagerPool();

    private static MoneySpawn instance;
    public static MoneySpawn Instance => instance;

    private void Awake()
    {
        InitializationSingleton();
        managerPool.AddPool(PoolType.Entities);
    }

    private void Start()
    {
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
        allMoneys.Add(managerPool.Spawn(PoolType.Entities, prefabMoney, placeSpawn[0].position));
        allMoneys[allMoneys.Count - 1].GetComponent<MoneyController>().speed = speed;
    }

    /// <summary>
    /// Деспавн монетки
    /// </summary>
    public void DespawnMoney(GameObject obj)
    {
        managerPool.Despawn(PoolType.Entities, obj);
    }
}