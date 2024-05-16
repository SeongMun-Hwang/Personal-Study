using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 20;
    private PlayerController7 playerControllerScript;

    private float leftBound = -15;
    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController7>();
    }
    void Update()
    {
        if (!playerControllerScript.gameOver)
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        if(transform.position.x< leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }          
    }
}
