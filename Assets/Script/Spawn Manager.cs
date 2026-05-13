using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnRangeZ = 20;

    void Start() { }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int randomIndex = Random.Range(0, AnimalPrefabs.Length);
            Vector3 SpawnPosition =  new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnRangeZ);
            Instantiate(AnimalPrefabs[randomIndex], SpawnPosition, Quaternion.Euler(0, 180, 0));
        }
    }
}