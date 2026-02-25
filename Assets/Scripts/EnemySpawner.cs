using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1.5f;
    public float xMin = -7f, xMax = 7f; // Horizontal bounds

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(xMin, xMax);
        Vector3 spawnPos = new Vector3(randomX, 6f, 0f); // Spawn above the screen
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
