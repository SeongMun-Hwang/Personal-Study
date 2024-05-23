using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float rotationSpeed = 50;
    void Start()
    {
        StartCoroutine(OpenDoor());
    }
    IEnumerator OpenDoor()
    {
        while (transform.eulerAngles.y < 90)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            yield return null;
        }
    }
    public IEnumerator CloseDoor()
    {
        while (transform.eulerAngles.y >= 0)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
