using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorController : MonoBehaviour
{
    public float rotationSpeed = 50;
    public GameObject rotateAxis;
    
    private bool isOpening = false;
    private bool isOpened = false;

    //Object name which approach to door
    private string objectName = "Player";
    private GameObject player;
    private Vector3 initialRotate;
    void Start()
    {
        player = GameObject.Find(objectName);
        initialRotate = transform.eulerAngles;
    }
    private void Update()
    {
        float distance = Vector3.Distance(transform.position,player.transform.position);
        if (distance < 2 && !isOpening)
        {
            Debug.Log("Opened");
            StartCoroutine(OpenDoor());
        }
        else if (distance >= 2 && !isOpening && isOpened)
        {
            Debug.Log("Closed");
            StartCoroutine(CloseDoor());
        }
    }
    IEnumerator OpenDoor()
    {
        isOpening = true;
        while (rotateAxis.transform.localEulerAngles.y < 90)
        {
            rotateAxis.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            yield return null;
        }
        isOpening = false;
        isOpened = true;
    }
    public IEnumerator CloseDoor()
    {
        isOpening = true;
        while (rotateAxis.transform.localEulerAngles.y > 1)
        {
            rotateAxis.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            yield return null;
        }
        isOpening = false;
        isOpened = false;
    }
}
