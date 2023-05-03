using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    public AudioSource bgmSource;

    public AudioSource sfxSource;

    void Awake() 
    {
        bgmSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        sfxSource = GameObject.Find("SFXManager").GetComponent<AudioSource>();
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void MusicVolume(float value)
    {
        bgmSource.volume = value;
    }

    public void EffectsVolume(float value)
    {
        sfxSource.volume = value;
    }

}
