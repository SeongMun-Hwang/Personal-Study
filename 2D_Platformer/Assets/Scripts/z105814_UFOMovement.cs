using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z105814_UFOMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private float xLimit = 13f;
    private Vector2 targetPosition;
    private GameObject player;
    public GameObject[] Light;
    private void Start()
    {
        targetPosition = new Vector2(xLimit, transform.position.y);
        StartCoroutine(LightControl());
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition.x == xLimit)
            {
                targetPosition.x = -xLimit;
            }
            else
            {
                targetPosition.x = xLimit;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet")){
            Destroy(gameObject);
        }
    }
    IEnumerator LightControl()
    {
        while(true){
            foreach (GameObject g in Light)
            {
                g.SetActive(false);
            }
            yield return new WaitForSeconds(1f);
            foreach (GameObject g in Light)
            {
                g.SetActive(true);
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
