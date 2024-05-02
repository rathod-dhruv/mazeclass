using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurboSpeed : MonoBehaviour
{
    public float speedMultiplier = 2.0f; // How much to multiply the speed by
    public float duration = 10.0f;
    private DeactivateBeacon _deactivateBeacon;

    private void Start()
    {
        _deactivateBeacon = FindObjectOfType<DeactivateBeacon>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OVRPlayerController playerController = other.gameObject.GetComponent<OVRPlayerController>();
            float newSpeed = playerController.Acceleration * speedMultiplier;
            playerController.Acceleration = newSpeed;
            playerController.SetMoveScaleMultiplier(newSpeed/playerController.Acceleration);
            _deactivateBeacon.reduceSpeedWithDelay(duration);
            Destroy(this.gameObject);
        }
    }
}
