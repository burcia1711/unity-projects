using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed = 100;
    private Rigidbody enemyRb;
    private GameObject player;
    private SpawnManagerX spawnManagerxScript;
    private int currentWave = 1;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        spawnManagerxScript = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        int wave = spawnManagerxScript.waveCount - 1;
        //if another wave has been spawned then we increase the speed
        if (currentWave != wave)
        {
            speed += speed * (wave - 1) * wave / 15;
            currentWave++;
        }
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
