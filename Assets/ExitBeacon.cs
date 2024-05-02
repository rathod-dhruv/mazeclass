using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBeacon : MonoBehaviour
{
    [SerializeField] private GameObject exitBeacon;
    public float duration = 10.0f;
    private DeactivateBeacon _deactivateBeacon;
    private void Start()
    {
        // exitBeacon = GameObject.Find("exitBeacon");
        _deactivateBeacon = FindObjectOfType<DeactivateBeacon>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            exitBeacon.SetActive(true);
            _deactivateBeacon.deactivateExitBeaconWithDelay(duration);
            Destroy(this.gameObject);
            // Invoke("deActivateBeacon", duration);
        }
    }

    public void deActivateBeacon()
    {
        Debug.Log("deactivating enemy beacon");
        exitBeacon.SetActive(false);
    }
    
}
