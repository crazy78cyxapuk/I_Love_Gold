using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int countScore = 0;

    [Header("Звук при попадании монетки в сундук")]
    [SerializeField] private AudioClip soundCoin;
    private AudioSource music;

    [Header("Текст для отображения кол-ва очков")]
    [SerializeField] private TextMeshProUGUI scoreTMP;

    private void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public bool isEnlargeSpeedMoney()
    {
        PlusScore();

        if(countScore % 100 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void PlusScore()
    {
        countScore += 5;
        scoreTMP.text = countScore.ToString();

        PlaySound();
    }

    private void PlaySound()
    {
        music.PlayOneShot(soundCoin);
    }
}
