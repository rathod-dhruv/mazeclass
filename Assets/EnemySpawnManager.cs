using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public float spawnEnemyOverhead = 6.0f;

    public GameObject enemy;

    public GameObject enemyBeacons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnEnemy()
    {
        Invoke("ExecuteAfterDelay", spawnEnemyOverhead);
    }
    void ExecuteAfterDelay()
    {
        enemy.SetActive(true);
        enemyBeacons.SetActive(true);
    }
}
