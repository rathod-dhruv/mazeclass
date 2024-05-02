using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBeacon : MonoBehaviour
{
    public GameObject enemyBeacon;
    public float speedMultiplier = 2.0f;
    public GameObject exitBeacon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deactivateEnemyBeaconWithDelay(float delay)
    {
        Invoke("deactivateEnemyBeacon", delay);
    }
    public void deactivateExitBeaconWithDelay(float delay)
    {
        Invoke("deactivateExitBeacon", delay);
    }

    public void reduceSpeedWithDelay(float delay)
    {
        Invoke("reduceSpeed",delay);
    }
    private void deactivateEnemyBeacon()
    {
        enemyBeacon.SetActive(false);
    }
    private void deactivateExitBeacon()
    {
        exitBeacon.SetActive(false);
    }

    private void reduceSpeed()
    {
        OVRPlayerController playerController = FindObjectOfType<OVRPlayerController>();
        float newSpeed = playerController.Acceleration / speedMultiplier;
        playerController.Acceleration = newSpeed;
        playerController.SetMoveScaleMultiplier(newSpeed/playerController.Acceleration);
    }
    
}
