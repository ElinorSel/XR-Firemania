using UnityEngine;
using System.Collections.Generic;

public class FireLogic : MonoBehaviour
{
    private GameManager gameManager; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {

        Destroy(gameObject);
        gameManager.IncreaseScore();
    }
}
