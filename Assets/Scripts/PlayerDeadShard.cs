using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadShard : MonoBehaviour
{
    private bool isCall = false;
    void Update()
    {
        if (GameManager.instance.isGameEnd && !isCall)
        {
            isCall = true;
            foreach (Transform child in transform)
            {
                child.position = PlayerController.instance.transform.position;
                Vector3 force = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
                
                child.GetComponent<Rigidbody>().AddForce(force * GameManager.instance.force, ForceMode.Impulse);
            }
        }
    }
}
