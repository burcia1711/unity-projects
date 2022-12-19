using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] pipes;
    private float spawnRangeX = 0;
    private float spawnPosZ = 10.36f;
    private float spawnPosY = -8.33f;
    private float startDelay = 1;
    private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        spawnRangeX += 5;
        int pipeIndex = Random.Range(0, pipes.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, spawnPosY, spawnPosZ);
        Instantiate(pipes[pipeIndex], spawnPos, pipes[pipeIndex].transform.rotation);
    }
}

