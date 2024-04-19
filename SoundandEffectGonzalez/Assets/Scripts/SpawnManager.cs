using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private int obstacleIndex;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay, repeatRate;
    private PlayerControler playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControler>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnObstacle()
    {
        obstacleIndex = Random.Range(0, 3);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
        }

        // change the repeatrate after each obstacle spwan

        repeatRate = Random.Range(1f, 2.5f);
        startDelay = Random.Range(1f, 2.5f);
        CancelInvoke();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

    }
}