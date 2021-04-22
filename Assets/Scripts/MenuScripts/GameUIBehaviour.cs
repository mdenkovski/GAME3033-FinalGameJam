using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIBehaviour : MonoBehaviour
{
    [SerializeField]
    private TMP_Text NumCoinsRemainingText;
    [SerializeField]
    private TMP_Text TimeRemainingText;

    private bool Enabled = false;
    private float TimeRemaining;

    private GameManager GameManager;

    private void Awake()
    {
        GameManager = FindObjectOfType<GameManager>();
        TimeRemainingText.text = $"0:00";
    }

    // Update is called once per frame
    void Update()
    {
        if (!Enabled) return;
        TimeRemaining -= Time.deltaTime;

        if (TimeRemaining <= 0)
        {
            Enabled = false;
            GameManager.GameLose();
            return;
            
        }

        TimeRemainingText.text = ((int)TimeRemaining).ToString();

        int minutes = Mathf.FloorToInt(TimeRemaining / 60F);
        int seconds = Mathf.FloorToInt(TimeRemaining % 60);
        TimeRemainingText.text = $"{minutes}:{seconds}";

        
    }

    public void Initialize(int numCoinsToCollect, float timeToCollectCoins)
    {
        NumCoinsRemainingText.text = numCoinsToCollect.ToString();
        Enabled = true;
        TimeRemaining = timeToCollectCoins;
    }

    public void UpdateNumCoins(int Num)
    {
        NumCoinsRemainingText.text = Num.ToString();
    }
}
