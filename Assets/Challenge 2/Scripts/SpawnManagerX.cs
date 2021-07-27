using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private int spawnLimitXLeft = -30;
    private int spawnLimitXRight = 0;
    private int spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ballPrefabColor;
        int randomSpawnRange = Random.Range(spawnLimitXLeft, spawnLimitXRight);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(randomSpawnRange, spawnPosY, 0);

        // instantiate ball at random spawn location
        if (randomSpawnRange <= -25)
        {
            ballPrefabColor = 2;
        }
        else if (randomSpawnRange <= -10)
        {
            ballPrefabColor = 1;
        }
        else ballPrefabColor = 0;

        Instantiate(ballPrefabs[ballPrefabColor], spawnPos, ballPrefabs[ballPrefabColor].transform.rotation);
    }

}
