using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float planeSpeed = 20;
    public float rotateSpeed = 20;
    public GameObject propeller;
    public float propellerSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        //전진,후진
        transform.Translate(Vector3.forward * Time.deltaTime * planeSpeed*x);
        //방향회전
        transform.Rotate(Vector3.up*Time.deltaTime * rotateSpeed*z);
        //프로펠러 회전
        propeller.transform.Rotate(Vector3.forward * propellerSpeed*x);
        
        //비행기 회전
       if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Rotate(-Vector3.left * Time.deltaTime * rotateSpeed);
        }
        //비행기 가속
        planeSpeed = Input.GetKey(KeyCode.LeftShift) ? 30 : 20;
    }
}
