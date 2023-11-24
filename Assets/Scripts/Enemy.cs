using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private GameObject player;
    private Rigidbody enemyRb;
    private GameManager gameManager;
    private SpawnManager spawnManager;
    public bool isBoss = false;
    private float nextSpawn;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        if (isBoss)
        {
            spawnManager = FindObjectOfType<SpawnManager>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = ((player.transform.position - transform.position).normalized);

        enemyRb.AddForce(lookDirection * speed);

        if (isBoss)
        {
            nextSpawn = Time.time + spawnInterval;
        }
    }

}
