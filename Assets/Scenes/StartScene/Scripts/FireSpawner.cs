using UnityEngine;
using System.Collections;

public class FireSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject[] firePrefabs;
    [SerializeField] private int spawnIntervalMinSeconds = 1;
    [SerializeField] private int spawnIntervalMaxSeconds = 10;
    [SerializeField] private int minFiresPerSpawnIntervall = 1;
    [SerializeField] private int maxFiresPerSpawnIntervall = 10;
    [SerializeField] private Vector3Int fireSpawnArea = new Vector3Int(10, 0, 10);

    int spawnInterval;
    Vector3 randomLocation;
    int numFireToSpawn;
    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawn fire at random intervalls
    IEnumerator SpawnTimer()
    {
        while (true) //TODO change this to gameOver condition
        {
            spawnInterval = Random.Range(spawnIntervalMinSeconds,spawnIntervalMaxSeconds);
            yield return new WaitForSeconds(spawnInterval);
            SpawnFire();            
        }

    }

    public void SpawnFire() //TODO spawnlogic: fire more likely to spread from existing fire locations
    {
        numFireToSpawn = Random.Range(minFiresPerSpawnIntervall, maxFiresPerSpawnIntervall);
        for(int i = 0; i < numFireToSpawn; i++)
        {
            //TODO: add logic to check if valid spawnLocation!
            randomLocation = new Vector3(
            Random.Range(-fireSpawnArea.x / 2, fireSpawnArea.x / 2),
            0.1f,
            Random.Range(-fireSpawnArea.z / 2, fireSpawnArea.z / 2));


            // Pick random prefab
            GameObject randomPrefab = firePrefabs[Random.Range(0, firePrefabs.Length)];

            GameObject newFire = Instantiate(randomPrefab, randomLocation, Quaternion.identity);
            // Random scale
            float scaleFactor = Random.Range(1f, 6f); 
            newFire.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        }
    }

}
