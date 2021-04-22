using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public bool IsRunning;

    private PlayerInput PlayerInput;

    private GameUIManager UIManager;


    private void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();
        UIManager = FindObjectOfType<GameUIManager>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnPause(InputValue value)
    {
        UIManager.ShowPauseMenu();
        PlayerInput.SwitchCurrentActionMap("Pause");
        Debug.Log("Pause");
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResumeGame()
    {
        UIManager.ShowGameMenu();
        PlayerInput.SwitchCurrentActionMap("Gameplay");
        Debug.Log("UnPause");
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
