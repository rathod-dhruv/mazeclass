using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public bool gameStarted = false;
    [SerializeField] private EnemySpawnManager _enemySpawnManager;
    [SerializeField] private GameVariable _gameVariable;
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("heh");
        if (!_gameVariable.gameStarted && !_gameVariable.gameWon && !_gameVariable.gameLost && other.gameObject.tag == "Player")
        {
            Debug.Log("hohoho");
            _gameVariable.gameStarted = true;
            _enemySpawnManager.spawnEnemy();
        }
    }
}
