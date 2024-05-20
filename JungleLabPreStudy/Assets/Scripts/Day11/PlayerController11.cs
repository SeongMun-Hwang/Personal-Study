using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController11 : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    public bool hasPowerUp;
    private float powerupStrencth = 15.0f;
    public GameObject powerUpIndiciator;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        powerUpIndiciator.transform.position = transform.position + new Vector3(0, -0.6f, 0);
        if (hasPowerUp)
        {
            powerUpIndiciator.transform.Rotate(Vector3.up, Time.deltaTime * 300);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            powerUpIndiciator.gameObject.SetActive(true);
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpTimer());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRb=collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            enemyRb.AddForce(awayFromPlayer*powerupStrencth,ForceMode.Impulse);
        }
    }
    IEnumerator PowerUpTimer()
    {
        yield return new WaitForSeconds(7.0f);
        powerUpIndiciator.gameObject.SetActive(false);
        hasPowerUp = false;
    }
}
