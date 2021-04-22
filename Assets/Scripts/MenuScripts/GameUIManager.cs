using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameObject PauseUIPanel;
    [SerializeField] GameObject GameUIPanel;

    private void OnEnable()
    {
        HideAllPanels();
        ShowGameMenu();
    }

    private void HideAllPanels()
    {
        PauseUIPanel.SetActive(false);
        GameUIPanel.SetActive(false);
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

}
