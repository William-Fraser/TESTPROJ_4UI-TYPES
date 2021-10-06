using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    public GameObject eventMarker;
    public GameObject player;
    void Start()
    {
        eventMarker.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (player.GetComponent<PlayerController>().Ammo < 6)
        {
            eventMarker.SetActive(true);
        }
        if (player.GetComponent<PlayerController>().Ammo == 6)
        {
            eventMarker.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        eventMarker.SetActive(false);
    }
}
