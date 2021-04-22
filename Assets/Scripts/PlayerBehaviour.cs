using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider))]
public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject SpawnPoint;

    public UnityEvent CoinCollected;

    private void Awake()
    {
        Respawn();
    }

    private void Respawn()
    {
        if (SpawnPoint)
        {
            transform.position = SpawnPoint.transform.position;
            transform.rotation = SpawnPoint.transform.rotation;

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //check if it is a pickup
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Colelcted coin");
            CoinCollected.Invoke();
            Destroy(other.gameObject);
        }
    }

    private void OnDestroy()
    {
        CoinCollected.RemoveAllListeners();
    }
}
