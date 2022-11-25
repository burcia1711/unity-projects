using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.RandomRange(-9, 9);
        float spawnPosZ = Random.RandomRange(-9, 9);
        Vector3 randomPos = new Vector3(spawnPosX, 0.13f, spawnPosZ);
        return randomPos;
    }
}
