using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalnput;
    public float playerSpeed = 20;
    public float xRange = 10;

    //food control
    public GameObject projectilePrefab;
    void Update()
    {
        horizontalnput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.right * Time.deltaTime * horizontalnput * playerSpeed);
        if (transform.position.x < -xRange) 
            transform.position=new Vector3(-xRange,transform.position.y,transform.position.z);
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
