using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InGameMenuManager : MonoBehaviour
{
    public static InGameMenuManager instance;
    [SerializeField] private GameObject menu;
    public bool isPaused = false;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    public void TogglePause()
    {
        if (isPaused)
        {
            menu.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            menu.SetActive(true);
            Time.timeScale = 0;
        }
        isPaused = !isPaused;
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
