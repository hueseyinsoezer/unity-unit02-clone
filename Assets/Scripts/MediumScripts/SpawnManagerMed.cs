using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerMed : MonoBehaviour
{
    private float spawnRangeX = 15;
    private float spawnRangeUpZ=11, spawnRangeDownZ=0;
    private float spawnPozX = 20, spawnPosZ = 20;
    public GameObject[] animalPrefabs;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        //Randomly generate animal index and spawn position
        Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(spawnPozX, 0, Random.Range(spawnRangeDownZ, spawnRangeUpZ));
        Vector3 spawnPosRight = new Vector3(-spawnPozX, 0, Random.Range(spawnRangeDownZ, spawnRangeUpZ));
        int animalIndex0 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex0], spawnPosTop,
            animalPrefabs[animalIndex0].transform.rotation);
        int animalIndex1 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex1], spawnPosLeft,
            Quaternion.Euler(0,270,0));
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex2], spawnPosRight,
            Quaternion.Euler(0, 90, 0));
    }
}
