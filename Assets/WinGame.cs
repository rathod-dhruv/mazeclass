using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] GameVariable _GameVariable;

    public GameObject winCanvas;
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
            if (_GameVariable.gameStarted && !_GameVariable.gameLost)
            {
                _GameVariable.gameWon = true;
                winCanvas.SetActive(true);
            }
        }
        
    }
}
