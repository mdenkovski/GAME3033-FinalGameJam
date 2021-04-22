using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameObject PauseUIPanel;

    private void OnEnable()
    {
        HideAllPanels();
    }

    private void HideAllPanels()
    {
        PauseUIPanel.SetActive(false);
    }

    public void ShowPauseMenu()
    {
        PauseUIPanel.SetActive(true);

    }
}
