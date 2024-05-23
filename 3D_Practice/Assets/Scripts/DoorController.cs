using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorController : MonoBehaviour
{
    public float rotationSpeed = 50;
    public GameObject rotateAxis;
    
    private bool isOpening = false;

    //Object name which approach to door
    private string objectName = "Player";
    private GameObject player;

    void Start()
    {
        player = GameObject.Find(objectName);
    }
    private void Update()
    {
        float distance = Math.Abs(transform.position.x - player.transform.position.x);
        if (distance < 2 && !isOpening)
        {
            StartCoroutine(OpenDoor());
        }
        else if (distance >= 2 && !isOpening)
        {
            StartCoroutine(CloseDoor());
        }
    }
    IEnumerator OpenDoor()
    {
        isOpening = true;
        while (rotateAxis.transform.eulerAngles.y < 90)
        {
            rotateAxis.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            yield return null;
        }
        isOpening = false;
    }
    public IEnumerator CloseDoor()
    {
        isOpening = true;
        while (rotateAxis.transform.eulerAngles.y > 1)
        {
            rotateAxis.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            yield return null;
        }
        isOpening = false;
    }
}
