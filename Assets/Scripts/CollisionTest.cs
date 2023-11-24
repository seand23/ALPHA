using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("FastZombie") || collision.gameObject.CompareTag("MiniZombie"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        //keeping track of score
        if (collision.gameObject.CompareTag("FastZombie"))
        {
            gameManager.UpdateScore(20);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameManager.UpdateScore(5);
        }
        if (collision.gameObject.CompareTag("MiniZombie"))
        {
            gameManager.UpdateScore(1);
        }

    }

}
