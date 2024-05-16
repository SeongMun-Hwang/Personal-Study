using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController7 : MonoBehaviour
{
    //jump
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    //move
    private float xInput;
    public float playerSpeed = 20;
    //gameover
    public bool gameOver = false;
    //animation
    private Animator playerAnimator;
    //particle
    public ParticleSystem explosionParicle;
    public ParticleSystem dirtParicele;
    //sound
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * xInput * Time.deltaTime * playerSpeed);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            dirtParicele.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParicele.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", Random.Range(1, 3));
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParicle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            dirtParicele.Stop();
        }
    }
}
