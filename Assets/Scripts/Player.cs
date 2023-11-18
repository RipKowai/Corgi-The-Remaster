using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;

    void Start()
    {
        GameManager.Instance.Health++;
    }

    void Update()
    {
        
    }
}
