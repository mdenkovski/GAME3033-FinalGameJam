using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float TimeToCollectCoins;
    private int NumCoinsToCollect;
    [SerializeField]
    private GameUIBehaviour GameUI;

    private void Awake()
    {
        FindObjectOfType<PlayerBehaviour>().CoinCollected.AddListener(OnCoinCollected);
        Initialize();
    }
   
    private void Initialize()
    {
        NumCoinsToCollect = GameObject.FindGameObjectsWithTag("Coin").Length;
        GameUI.Initialize(NumCoinsToCollect, TimeToCollectCoins);

    }
    private void OnCoinCollected()
    {
        NumCoinsToCollect--;
        GameUI.UpdateNumCoins(NumCoinsToCollect);

        if (NumCoinsToCollect <= 0)
        {
            //TODO: trigger game win
        }
    }
}
