using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    //Position to move
    public Transform destination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger");
            other.transform.Translate(destination.position, Space.World);
        }
    }
}
