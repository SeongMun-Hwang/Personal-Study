using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class z105814_PlayerController : MonoBehaviour
{
    public float moveSpeed = 30f;
    public float jumpForce = 30f;
    public float cameraDistanceY = 3f;
    public float boosterPower = 1f;
    public Camera mainCamera;

    private z105814_GameManager gameManager;
    private Rigidbody2D playerRb;
    private bool isJumped = false;
    private bool jumpCool = false;
    private float dashCoolTime = 5f;
    private bool isDash = false;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<z105814_GameManager>();
    }

    void Update()
    {
        float horizontoalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontoalInput * Time.deltaTime * moveSpeed);
        //mainCamera.transform.Translate(Vector3.right * horizontoalInput * Time.deltaTime * moveSpeed);
        if (Input.GetKeyDown(KeyCode.Space)&&!isJumped&&!jumpCool)
        {
            isJumped=true;
            jumpCool=true;
            StartCoroutine(JumpCoolDown());
            playerRb.AddForce(Vector2.up * jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)&&!isDash)
        {
            isDash = true;
            playerRb.AddForce(Vector2.right * horizontoalInput * boosterPower,ForceMode2D.Impulse);
            StartCoroutine(DashCoolDown());
        }
        mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, transform.position.y+ cameraDistanceY, mainCamera.transform.position.z);
    }
    private void OnDestroy()
    {
        gameManager.isGameOver = true;
        gameManager.isGameActive = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (!collision.gameObject.CompareTag("Item"))
        {
            isJumped = false;
        }
    }
    IEnumerator DashCoolDown()
    {
        yield return new WaitForSeconds(0.1f);
        playerRb.velocity = new Vector2(0, playerRb.velocity.y);
        yield return new WaitForSeconds(dashCoolTime);
        isDash = false;
    }
    IEnumerator JumpCoolDown()
    {
        yield return new WaitForSeconds(1f);
        jumpCool = false;
    }
}
