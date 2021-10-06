using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().Ammo = 6;
        }
    }
}
