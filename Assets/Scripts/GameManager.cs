using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    public int Score;

    
}
