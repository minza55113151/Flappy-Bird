using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject[] menus;

    [SerializeField] private Slider backgroundMusicSlider;
    [SerializeField] private Slider sfxSlider;
    
    private void Start()
    {
        backgroundMusicSlider.value = SoundManager.instance.GetBackgroundMusicVolume();
        sfxSlider.value = SoundManager.instance.GetSFXVolume();

        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
        }
        menus[0].SetActive(true);
    }
    public void OpenMenu(string menuName)
    {
        {
            for (int i = 0; i < menus.Length; i++)
            {
                if (menus[i].name == menuName)
                {
                    menus[i].SetActive(true);
                }
                else
                {
                    menus[i].SetActive(false);
                }
            }
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
        
    public void CloseGame()
    {
        Application.Quit();
    }
    private void Update()
    {
        SetBackgroundMusicVolume(backgroundMusicSlider.value);
        SetSFXVolume(sfxSlider.value);
    }
    public void SetBackgroundMusicVolume(float volume)
    {
        SoundManager.instance.SetBackgroundMusicVolume(volume);
    }
    public void SetSFXVolume(float volume)
    {
        SoundManager.instance.SetSFXVolume(volume);
    }
}
