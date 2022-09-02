using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject powerupPrefab;

    [Space]
    [SerializeField] private float xRange = 7.5f;
    [SerializeField] private float yRange = 9.5f;

    [Space]
    public int enemyCount;
    public int waveNumber = 1;

    private void Update()
    {
        SpawnNewWaveIfNoneAlive();
    }

    private void SpawnNewWaveIfNoneAlive()
    {
        enemyCount = transform.childCount;

        if (enemyCount == 0)
        {
            SpawnEnemyWave(waveNumber);

            SpawnPowerup();

            waveNumber++;
        }
    }

    private void SpawnEnemyWave(int spawnCount)
    {
        for (int count = 0; count < spawnCount; count++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, GenerateRandomPosition(), enemyPrefab.transform.rotation, transform);
    }

    private Vector3 GenerateRandomPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange),
            0, Random.Range(-yRange, yRange));
    }

    private void SpawnPowerup()
    {
        Instantiate(powerupPrefab, GenerateRandomPosition(), powerupPrefab.transform.rotation, transform);
    }
}
