using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    const float cooldown = 2;

    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] int obstaclesToSpawn = 3;  // Número de obstáculos a gerar

    private void Update()
    {
        if (clock <= 0)
        {
            clock = cooldown;

            // Gerar múltiplos obstáculos
            SpawnObstacles(obstaclesToSpawn);
        }
        else
        {
            clock -= Time.deltaTime;
        }
    }

    // Método para gerar múltiplos obstáculos
    void SpawnObstacles(int numberOfObstacles)
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector2 spawnPosition = new Vector2(GameManager.instance.ScreenBounds.x, Random.Range(-2, 2));
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }
    }
}




