using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    public GameObject EventMarker;
    void Start()
    {
        EventMarker.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        EventMarker.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        EventMarker.SetActive(false);
    }
}
