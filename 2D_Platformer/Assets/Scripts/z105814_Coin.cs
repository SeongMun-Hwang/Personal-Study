using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z105814_Coin : MonoBehaviour
{
    private z105814_GameManager gameManager;
    public float rotateSpeed = 10.0f;
    void Start()
    {
        gameManager=GameObject.Find("GameManager").GetComponent<z105814_GameManager>();
    }
    private void Update()
    {
        transform.Rotate(Vector2.up, Time.deltaTime * rotateSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.score += 10;
            Destroy(gameObject);
        }
    }
}
