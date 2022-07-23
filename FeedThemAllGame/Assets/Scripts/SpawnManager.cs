using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    public float spawnRangeX = 20;
    private float spawnPosZ = 14.5f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalVertical", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalHorizontalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalHorizontalRight", startDelay, spawnInterval);
    }
    // w: rearrange
    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalVertical()
    {
        Debug.Log("Worked");
        // Randomly generate animal index and spawn position            
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 180, 0));
        Debug.Log("Workeeeed");

    }

    void SpawnRandomAnimalHorizontalLeft()
    {
        Debug.Log("Worked 2");
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // TODO: learn below
        Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));
        Debug.Log("Workeeeed 2");
    }

    void SpawnRandomAnimalHorizontalRight()
    {
        Debug.Log("Worked 3");
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // TODO: learn below
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));
        Debug.Log("Workeeeed 3");
    }
}
