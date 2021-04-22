using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUIBehaviour : MonoBehaviour
{
    public void OnResumeGame()
    {
        UnpauseGame();
    }

    public void OnMainMenu()
    {
        UnpauseGame();
        SceneManager.LoadScene("MainMenu");
    }

    private void UnpauseGame()
    {
        Time.timeScale = 1.0f;
    }
}
