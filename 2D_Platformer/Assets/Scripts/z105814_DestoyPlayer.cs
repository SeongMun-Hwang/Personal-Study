using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z105814_DestoyPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        if (transform.CompareTag("Bullet") && collision.gameObject.CompareTag("Weak"))
        {
            Destroy(collision.gameObject);
        }
    }
}
