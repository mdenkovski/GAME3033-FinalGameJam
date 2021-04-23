using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider))]
public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject SpawnPoint;

    public UnityEvent CoinCollected;

    private PlayerMovement PlayerMovement;
    private NavMeshAgent NavAgent;

    [SerializeField]
    private float SpeedIncreaseAmount = 2;
    [SerializeField]
    private float SpeedIncreaseDuration = 5;

    private void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
        NavAgent = GetComponent<NavMeshAgent>();
        Respawn();
    }

    private void Respawn()
    {
        if (SpawnPoint)
        {
            NavAgent.enabled = false;
            transform.position = SpawnPoint.transform.position;
            transform.rotation = SpawnPoint.transform.rotation;
            NavAgent.enabled = true;

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //check if it is a coin
        if (other.gameObject.CompareTag("Coin"))
        {
            //Debug.Log("Colelcted coin");
            CoinCollected.Invoke();
            other.gameObject.GetComponent<ItemColliderBehaviour>().ConsumeItem();
        }
        else if (other.gameObject.CompareTag("SpeedBoost")) //check if a speed boost
        {
            //Debug.Log("Vroom Vroom");
            StartCoroutine(ApplySpeedBoost());
            other.gameObject.GetComponent<ItemColliderBehaviour>().ConsumeItem();
        }
        else if (other.gameObject.CompareTag("SlowItem")) //check if a slow item
        {
            StartCoroutine(SlowSpeed());
            other.gameObject.GetComponent<ItemColliderBehaviour>().ConsumeItem();
        }
    }

    private void OnDestroy()
    {
        CoinCollected.RemoveAllListeners();
    }

    IEnumerator ApplySpeedBoost()
    {
        PlayerMovement.IncreaseSpeed(SpeedIncreaseAmount);
        yield return new WaitForSeconds(SpeedIncreaseDuration);
        PlayerMovement.DecreaseSpeed(SpeedIncreaseAmount);
    }

    IEnumerator SlowSpeed()
    {
        PlayerMovement.DecreaseSpeed(SpeedIncreaseAmount);
        yield return new WaitForSeconds(SpeedIncreaseDuration);
        PlayerMovement.IncreaseSpeed(SpeedIncreaseAmount);
    }
}
