using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance !=null)
        {
            Debug.LogError("[GAMMANAGER] Too many Game Managers");
        }

        Instance = this;
    }
    #endregion

    void Start()
    {
        UpdateGameState(GameState.MainMenu);
    }

    public int Health;

    public GameState State;

    public static event Action<GameState> StateChanged;

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.ChangeSkin:
                HandleChangeSkin();
                break;
            case GameState.Victory:
                break;
            case GameState.Lose:
                break;
            case GameState.Paused:
                break;
            case GameState.MainMenu:
                break;
            case GameState.Playing:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        StateChanged?.Invoke(newState);
    }

    private void HandleChangeSkin()
    {
       
    }
}
public enum GameState
{
    MainMenu,
    Playing,
    Paused,
    ChangeSkin,
    Victory,
    Lose
}
