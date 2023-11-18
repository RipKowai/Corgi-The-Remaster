using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject changeSkin;

    void Awake()
    {
        GameManager.StateChanged += GamemanagerStateChanged;
    }

    void OnDestroy()
    {
        GameManager.StateChanged -= GamemanagerStateChanged;
    }

    private void GamemanagerStateChanged(GameState state)
    {
        changeSkin.SetActive(state == GameState.ChangeSkin);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
