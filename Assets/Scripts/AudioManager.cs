using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;

    [SerializeField]
    private AudioSource CoinPickupSound;
    [SerializeField]
    private AudioSource SpeedUpItemSound;
    [SerializeField]
    private AudioSource SlowDownItemSound;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayCoinPickup()
    {
        CoinPickupSound.Play();
    }

    public void PlaySpeedUpEffect()
    {
        SpeedUpItemSound.Play();

    }

    public void PlaySlowDownEffect()
    {
        SlowDownItemSound.Play();

    }
}
