using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound backgroundMusic;
    public Sound[] sfx;
    public AudioSource backgroundMusicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        backgroundMusicSource.clip = backgroundMusic.audioClip;
        backgroundMusicSource.Play();
    }

    public void PlaySFX(string name)
    {
        Sound sound = Array.Find(sfx, x => x.audioName == name);

        if (sound == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(sound.audioClip);
        }
    }
}
