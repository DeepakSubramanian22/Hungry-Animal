using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnRangeZ = 20;
    private float SpawnDelay = 2;
    private float SpawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",SpawnDelay, SpawnInterval);
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int randomIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 SpawnPosition =  new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnRangeZ);
        Instantiate(AnimalPrefabs[randomIndex], SpawnPosition, Quaternion.Euler(0, 180, 0));
    }
}