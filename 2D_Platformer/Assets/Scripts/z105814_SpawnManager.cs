using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class z105814_SpawnManager : MonoBehaviour
{
    public GameObject[] platforms;

    public GameObject bullet;
    private float bulletDealy = 1;
    private float bulletRepeat = 2;
    public float bulletAppear = 150f;
    public float waitTime = 2f;


    public GameObject rocket;
    public GameObject ufo;
    public float ufoAppear = 300f;
    public GameObject coin;

    private Vector2 spawnPos;
    private z105814_PlayerController playerController;
    private float startDelay = 1;
    private float repeatDelay = 2;

    //environment
    public GameObject water;
    public float waterSpeed = 0.5f;
    //spawnPos
    private Vector2 previousSpawnPos;

    private float spawnRangeX = 15f;
    public float bulletSpawnPosY = 16f;
    private z105814_GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<z105814_GameManager>();
        playerController = GameObject.Find("Player").GetComponent<z105814_PlayerController>();
        InvokeRepeating("SpawnPlatform", startDelay, repeatDelay);
        InvokeRepeating("SpawnCoin", startDelay, repeatDelay);
        InvokeRepeating("SpawnRocket", bulletDealy, 10);
        InvokeRepeating("SpawnUFO", bulletDealy, 10);
        StartCoroutine(SpawnBullet());
    }

    void Update()
    {

        bulletRepeat = bulletAppear / gameManager.height * 5;

        Debug.Log("bullet Repeat : " + bulletRepeat);
        if (!gameManager.isGameOver)
        {
            water.transform.position += new Vector3(0, (waterSpeed + gameManager.height / 75) * Time.deltaTime);
        }
    }

    void SpawnPlatform()
    {
        if (!gameManager.isGameOver)
        {
            int index = Random.Range(0, platforms.Length);
            GameObject g = Instantiate(platforms[index], MakeSpawnPos(), platforms[index].transform.rotation);
            float newScale = g.transform.localScale.x * Random.Range(1, 4) / 2f;
            g.transform.localScale = new Vector2(newScale, g.transform.localScale.y);
        }
    }
    IEnumerator SpawnBullet()
    {
        Debug.Log("height : " + gameManager.height);
        while (!gameManager.isGameOver)
        {

            Instantiate(bullet, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), bulletSpawnPosY + playerController.transform.position.y), bullet.transform.rotation);

            yield return new WaitForSeconds(bulletRepeat);

        }
    }
    Vector2 MakeSpawnPos()
    {
        Vector2 playerPosition = playerController.transform.position;
        Vector2 spawnPos;
        do
        {
            spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), playerPosition.y + Random.Range(6, 10));
        }
        while (Vector2.Distance(spawnPos, previousSpawnPos) < 2);

        previousSpawnPos = spawnPos;
        return spawnPos;
    }
    void SpawnRocket()
    {
        if (GameObject.Find("Rocket(Clone)") == null && !gameManager.isGameOver)
        {
            Instantiate(rocket, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), 11 + playerController.transform.position.y), rocket.transform.rotation);
        }
    }
    void SpawnUFO()
    {
        if (!gameManager.isGameOver && gameManager.height > ufoAppear)
        {
            GameObject ufoClone = Instantiate(ufo, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), 11 + playerController.transform.position.y), ufo.transform.rotation);
            ufoClone.GetComponent<z105814_UFOMovement>().moveSpeed = 10f / ufoAppear * gameManager.height;
        }
    }
    void SpawnCoin()
    {
        if (!gameManager.isGameOver)
        {
            Instantiate(coin, MakeSpawnPos(), coin.transform.rotation);
        }
    }
}
