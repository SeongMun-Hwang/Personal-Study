using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPhysics : MonoBehaviour
{
    private float damage = 0;
    public float maxDamamge;
    private float randomRotateRange = 30;

    public GameObject parent;
    public GameObject[] rocks;

    private void Update()
    {
        if (damage > maxDamamge)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        Vector3 impactVelocity = collision.relativeVelocity;
        Rigidbody myRb = GetComponent<Rigidbody>();
        float impactForceMagnitude = myRb.mass * impactVelocity.magnitude / Time.fixedDeltaTime;
        Vector3 impactForce = impactForceMagnitude * impactVelocity.normalized;
        Debug.Log("Impact : " + impactForce);
        damage += impactForce.magnitude;
    }
    private void OnDestroy()
    {
        foreach (var rock in rocks)
        {
            rock.transform.position = transform.position;
            float randomRotation = Random.Range(-randomRotateRange, randomRotateRange);

            rock.transform.rotation = Quaternion.Euler(randomRotation, randomRotation, randomRotation);
            rock.SetActive(true);
        }
    }
}
