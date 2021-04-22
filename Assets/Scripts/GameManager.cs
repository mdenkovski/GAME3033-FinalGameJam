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
    private GameUIManager UIManager;

    private PlayerController PlayerController;

    private void Awake()
    {
        FindObjectOfType<PlayerBehaviour>().CoinCollected.AddListener(OnCoinCollected);
        UIManager = FindObjectOfType<GameUIManager>();
        PlayerController = FindObjectOfType<PlayerController>();
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
            GameWin();
        }
    }

    private void GameWin()
    {
        PlayerController.GameEnded();
        UIManager.ShowGameWin();
    }

    public void GameLose()
    {
        PlayerController.GameEnded();
        UIManager.ShowGameLose();
    }
}
