using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Make sure collision occurs with Player
        if (!other.gameObject.CompareTag("Player")) return;
        
        other.gameObject.GetComponent<PlayerHandler>().UpdateNumberOfCoins();
        EventManager.OnCoinCollected(transform.position);
        Destroy(gameObject);
    }
}
