using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject restartButton;

    public void GameOver()
{
    restartButton.SetActive(true);

    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
}

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}