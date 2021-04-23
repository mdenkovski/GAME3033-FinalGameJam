using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUIBehaviour : MonoBehaviour
{
    public void OnResumeGame()
    {
        PlayerController controller = FindObjectOfType<PlayerController>();
        controller.ResumeGame();
    }

    public void OnMainMenu()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenu");
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
    
}
