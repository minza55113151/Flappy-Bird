using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float time;
    void Update()
    {
        time += Time.deltaTime;
        if(time > GameManager.instance.pipeSpawnRate)
        {
            time -= GameManager.instance.pipeSpawnRate;
            SpawnPipe();
        }
    }
    void SpawnPipe()
    {
       if(GameManager.instance.isGameStart && !GameManager.instance.isGameEnd)
        {
            GameObject pipe = Instantiate(GameManager.instance.pipePrefab, new Vector3(GameManager.instance.spawnX, Random.Range(4, -4), 0f), Quaternion.identity);
        }
    }
}
