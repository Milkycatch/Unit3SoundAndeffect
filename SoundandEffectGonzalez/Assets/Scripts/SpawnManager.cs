using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControler playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
       
            Instantiate(obstaclePrefab,spawnPos, obstaclePrefab.transform.rotation);
        
    }
}

