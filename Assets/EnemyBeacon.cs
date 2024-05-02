using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeacon : MonoBehaviour
{
    [SerializeField] private GameObject enemyBeacon;
    public float duration = 10.0f;
    private DeactivateBeacon _deactivateBeacon;
    private void Start()
    {
        // enemyBeacon = GameObject.Find("enemyBeacon");
        _deactivateBeacon = FindObjectOfType<DeactivateBeacon>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemyBeacon.SetActive(true);
            // Invoke("deActivateBeacon", duration);
            _deactivateBeacon.deactivateEnemyBeaconWithDelay(duration);
            Destroy(this.gameObject);
        }
    }

    private void deActivateBeacon()
    {
        enemyBeacon.SetActive(false);
    }
}
