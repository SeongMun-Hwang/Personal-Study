using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer8 : MonoBehaviour
{
    public float moveSpeed = 20;
    private float zBound = 4;
    private float xBound = 9;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * x * moveSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * z * moveSpeed);

        if (transform.position.z < -zBound)
        {
            transform.position=new Vector3(transform.position.x,transform.position.y,-zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }
}
