using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private Rigidbody rb;
    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape) && !GameManager.instance.isGameStart && !InGameMenuManager.instance.isPaused)
        {
            GameManager.instance.isGameStart = true;
            rb.useGravity = true;
        }

        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape) && GameManager.instance.isGameStart && !GameManager.instance.isGameEnd && !InGameMenuManager.instance.isPaused)
        {
            rb.velocity = new Vector3(0, GameManager.instance.jumpForce, 0);
            SoundManager.instance.PlayHopSound();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        GameManager.instance.isGameEnd = true;
        SoundManager.instance.PlayDeadSound();
        Invoke("Restart", 1f);
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
