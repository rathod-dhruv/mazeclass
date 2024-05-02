using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    public GameVariable _GameVariable;

    public GameObject loseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (_GameVariable.gameStarted == true && !_GameVariable.gameWon)
            {
                _GameVariable.gameLost = true;
                loseCanvas.SetActive(true);
            }
        }
        
    }
}
