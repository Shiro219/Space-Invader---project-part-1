using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs; 

    public int rows = 5;
    public int columns = 11;

    public float spacingX = 1.2f;
    public float spacingY = 1.0f;

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector3 position = transform.position +
                                   new Vector3(col * spacingX, -row * spacingY, 0);

                GameObject enemyType = enemyPrefabs[row % enemyPrefabs.Length];
                Instantiate(enemyType, position, Quaternion.identity, transform);
            }
        }
    }
}