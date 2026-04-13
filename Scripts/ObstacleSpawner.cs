using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    public float spawnX = 10f;
   float minY = 0.7f;
float maxY = 0.7f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnRate);
    }

    void SpawnObstacle()
    {
        float y = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(spawnX, y, 0);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
