using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z105814_WeakPlatform : MonoBehaviour
{
    private int count = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.CompareTag("Player"))
        {
            count++;
            Debug.Log("Count : " + count);
            if(count == 2) { Destroy(gameObject); }
        }
    }
}
