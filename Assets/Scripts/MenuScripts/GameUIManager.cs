using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameObject PauseUIPanel;
    [SerializeField] GameObject GameUIPanel;
    [SerializeField] GameObject GameWinPanel;
    [SerializeField] GameObject GameLosePanel;

    private void OnEnable()
    {
        HideAllPanels();
        ShowGameMenu();
    }

    private void HideAllPanels()
    {
        PauseUIPanel.SetActive(false);
        GameUIPanel.SetActive(false);
        GameWinPanel.SetActive(false);
        GameLosePanel.SetActive(false);
    }

    public void ShowPauseMenu()
    {
        HideAllPanels();
        PauseUIPanel.SetActive(true);

    }

    public void ShowGameMenu()
    {
        HideAllPanels();
        GameUIPanel.SetActive(true);

    }

    public void ShowGameWin()
    {
        HideAllPanels();
        GameWinPanel.SetActive(true);
    }

    public void ShowGameLose()
    {
        HideAllPanels();
        GameLosePanel.SetActive(true);
    }

}
