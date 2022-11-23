using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    void Update()
    {
        if (GameManager.instance.isGameStart && !GameManager.instance.isGameEnd)
        {
            transform.Translate(GameManager.instance.pipeSpeed * Time.deltaTime, 0, 0);
        }
        if (transform.position.x < GameManager.instance.deSpawnX)
        {
            Destroy(gameObject);
        }
    }
}
