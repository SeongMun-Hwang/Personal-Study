using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float planeSpeed = 20;
    public float rotateSpeed = 20;
    public GameObject propeller;
    public float propellerSpeed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * planeSpeed*x);
        transform.Rotate(Vector3.up * Time.deltaTime * z * rotateSpeed);
        if (x != 0)
        {
            propeller.transform.Rotate(Vector3.forward * propellerSpeed);
        }
    }
}
