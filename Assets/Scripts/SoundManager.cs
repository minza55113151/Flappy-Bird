using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private GameObject backgroundASGameObject;
    private AudioSource backgroundAS;
    [SerializeField] private GameObject sfxASGameObject;
    private AudioSource sfxAS;

    [SerializeField] private AudioClip hopSound;
    [SerializeField] private AudioClip pointSound;
    [SerializeField] private AudioClip deadSound;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(backgroundASGameObject);
            Destroy(sfxASGameObject);
            Destroy(gameObject);
            return;
        }

        backgroundAS = backgroundASGameObject.GetComponent<AudioSource>();
        sfxAS = sfxASGameObject.GetComponent<AudioSource>();

        DontDestroyOnLoad(backgroundASGameObject);
        DontDestroyOnLoad(sfxASGameObject);
        DontDestroyOnLoad(gameObject);

        backgroundAS.loop = true;
        backgroundAS.Play();
    }

    public void PlayHopSound()
    {
        sfxAS.PlayOneShot(hopSound);
    }
    public void PlayPointSound()
    {
        sfxAS.PlayOneShot(pointSound);
    }
    public void PlayDeadSound()
    {
        sfxAS.PlayOneShot(deadSound);
    }
    
    public float GetBackgroundMusicVolume()
    {
        return backgroundAS.volume;
    }
    public void SetBackgroundMusicVolume(float volume)
    {
        backgroundAS.volume = volume;
    }
    public float GetSFXVolume()
    {
        return sfxAS.volume;
    }
    public void SetSFXVolume(float volume)
    {
        sfxAS.volume = volume;
    }

}
