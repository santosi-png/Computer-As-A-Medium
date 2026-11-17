using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something touched the coin: " + other.name);

        if (other.CompareTag("Player") || other.transform.root.CompareTag("Player"))
        {
            Debug.Log("Player collected coin!");

            GameManager manager = FindObjectOfType<GameManager>();

            if (manager != null)
            {
                manager.AddScore(1);
            }

            Destroy(gameObject);
        }
    }
}