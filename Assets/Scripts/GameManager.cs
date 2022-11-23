using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameStart;
    public bool isGameEnd;
    public float jumpForce;
    public float pipeSpeed;
    public float spawnX;
    public float deSpawnX;
    public float force;
    public float pipeSpawnRate;
    public GameObject pipePrefab;
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        isGameStart = false;
        isGameEnd = false;
    }
    
}
