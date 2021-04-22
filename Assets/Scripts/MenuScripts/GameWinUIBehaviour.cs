using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinUIBehaviour : MonoBehaviour
{
    public void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnPlayAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
