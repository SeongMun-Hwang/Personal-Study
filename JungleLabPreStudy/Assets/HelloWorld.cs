using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public string MyMessage;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MyMessage);
    }
}
