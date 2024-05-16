using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager7 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 1;
    private float repeatDelay = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
