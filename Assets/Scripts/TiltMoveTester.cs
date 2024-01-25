using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMoveTester : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("colliding with something");
        if (other.gameObject.CompareTag("TiltActivator"))
        {
            Debug.Log("                 Colliding with Tilt Activator");
        }
    }
}
