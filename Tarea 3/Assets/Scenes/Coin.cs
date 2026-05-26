using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager manager = FindObjectOfType<CoinManager>();

            manager.AddCoin();

            coinSound.Play();

            Destroy(gameObject);
        }
    }
}