using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    public float jumpStrength;
    private Rigidbody playerRb;
    private bool isJump = false;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        playerRb = GetComponent<Rigidbody>();

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * moveSpeed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space)&&!isJump)
        {
            isJump = true;
            playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isJump = false;
    }
}
