using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Start()
    {
        GameManager.Instance.Score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
