using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("GANASTE");

            GetComponent<AudioSource>().Play();

            winText.SetActive(true);

            Invoke("StopGame", 1f);
        }
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }
}