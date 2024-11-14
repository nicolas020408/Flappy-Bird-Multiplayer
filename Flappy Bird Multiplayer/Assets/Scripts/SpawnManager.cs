using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    const float cooldown = 2;

    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] int obstaclesToSpawn = 3;  // N�mero de obst�culos a gerar

    private void Update()
    {
        if (clock <= 0)
        {
            clock = cooldown;

            // Gerar m�ltiplos obst�culos
            SpawnObstacles(obstaclesToSpawn);
        }
        else
        {
            clock -= Time.deltaTime;
        }
    }

    // M�todo para gerar m�ltiplos obst�culos
    void SpawnObstacles(int numberOfObstacles)
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector2 spawnPosition = new Vector2(GameManager.instance.ScreenBounds.x, Random.Range(-2, 2));
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }
    }
}




