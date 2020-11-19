using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int countScore = 0;

    [SerializeField] private AudioClip soundCoin;
    private AudioSource music;

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

        PlaySound();
    }

    private void PlaySound()
    {
        music.PlayOneShot(soundCoin);
    }
}
