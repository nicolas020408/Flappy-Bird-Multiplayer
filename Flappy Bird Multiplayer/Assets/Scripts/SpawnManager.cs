using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    const float cooldown = 2;

    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] int numberOfObstacles = 5;  // Número de obstáculos a gerar

    private void Update()
    {
        if (clock <= 0)
        {
            clock = cooldown;

            // Laço para gerar múltiplos obstáculos ao mesmo tempo
            for (int i = 0; i < numberOfObstacles; i++)
            {
                Vector2 spawnPosition = new Vector2(GameManager.instance.ScreenBounds.x, Random.Range(-2, 2));
                Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
            }
        }
        else
        {
            clock -= Time.deltaTime;
        }
    }
}

