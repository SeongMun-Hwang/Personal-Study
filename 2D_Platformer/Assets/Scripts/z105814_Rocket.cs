using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z105814_Rocket : MonoBehaviour
{
    public float rocketPower = 1500;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * rocketPower,ForceMode2D.Impulse);
            StartCoroutine(RbOff(rb));
        }
    }

    IEnumerator RbOff(Rigidbody2D rb)
    {
        rb.isKinematic = true;
        yield return new WaitForSeconds(2.0f);
        rb.isKinematic = false;
        Destroy(gameObject);
    }
}
