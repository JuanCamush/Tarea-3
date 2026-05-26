using UnityEngine;
using TMPro;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI countdownText;

    void Start()
    {
        Time.timeScale = 0f;

        StartCoroutine(BeginGame());
    }

    IEnumerator BeginGame()
    {
        countdownText.text = "Inicias en 3";
        yield return new WaitForSecondsRealtime(1f);

        countdownText.text = "Inicias en 2";
        yield return new WaitForSecondsRealtime(1f);

        countdownText.text = "Inicias en 1";
        yield return new WaitForSecondsRealtime(1f);

        countdownText.gameObject.SetActive(false);

        menu.SetActive(false);

        Time.timeScale = 1f;
    }
}