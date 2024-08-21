using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    const float cooldown = 2;

    string obstaclePrefab = "Prefabs/Obstacle";

    private void Update()
    {
        if (NetworkManager.instance.IsMasterClient)
        {
            if (clock <= 0)
            {
                clock = cooldown;

                NetworkManager.instance.Instantiate(obstaclePrefab, new Vector2(GameManager.instance.ScreenBounds.x, Random.Range(-2, 2)), Quaternion.identity);
            }
            else
            {
                clock -= Time.deltaTime;
            }
        }
    }

}
