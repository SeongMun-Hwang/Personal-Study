using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
