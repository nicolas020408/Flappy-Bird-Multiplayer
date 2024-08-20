using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    const float cooldown = 2;

    [SerializeField] GameObject obstaclePrefab;

    private void Update()
    {
        if(clock <= 0)
        {
            clock = cooldown;

            Instantiate(obstaclePrefab, new Vector2(GameManager.instance.ScreenBounds.x, Random.Range(-2,2)), Quaternion.identity);
        }
        else
        {
            clock -= Time.deltaTime;
        }
    }

}
