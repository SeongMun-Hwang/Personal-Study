using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    // Position to move to
    public Transform destination;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.position = destination.position;
        }
    }
}
