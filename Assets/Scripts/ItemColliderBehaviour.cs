using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemColliderBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject RootGameObject;

    [SerializeField]
    private ItemType ItemType;

    public void ConsumeItem()
    {
        switch (ItemType)
        {
            case ItemType.Coin:
                AudioManager.Instance.PlayCoinPickup();
                break;
            case ItemType.SpeedUp:
                AudioManager.Instance.PlaySpeedUpEffect();
                break;
            case ItemType.SlowDown:
                AudioManager.Instance.PlaySlowDownEffect();
                break;
            default:
                break;
        }

        Destroy(RootGameObject);
    }
}

public enum ItemType
{
    Coin,
    SpeedUp,
    SlowDown
}