using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    [Header("Экран игры")]
    [SerializeField] private GameObject GameScreen;

    [Header("Экран загрузки")] 
    [SerializeField] private GameObject LoadScreen;


    [Header("Сколько длится загрузка")]
    [SerializeField] private float timer = 3;

    private void Start()
    {
        StartCoroutine(GoGame());
    }

    IEnumerator GoGame()
    {
        yield return new WaitForSeconds(timer);

        SwapScreen(GameScreen, LoadScreen);
        MoneySpawn.Instance.NewGame();
    }

    private void SwapScreen(GameObject objOn, GameObject objOff)
    {
        objOn.SetActive(true);
        objOff.SetActive(false);
    }
}
