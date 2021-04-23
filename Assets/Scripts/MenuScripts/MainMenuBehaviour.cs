using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    
    public void OnPlayGamePressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnInstructionsPressed()
    {
        SceneManager.LoadScene("Instructions");

    }

    public void OnCreditsPressed()
    {
        SceneManager.LoadScene("Credits");

    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
