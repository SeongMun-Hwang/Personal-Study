using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class z105814_Goal : MonoBehaviour
{
    public TextMeshProUGUI Instruction;
    private z105814_GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<z105814_GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.isGameOver = true;
        }
    }
}
