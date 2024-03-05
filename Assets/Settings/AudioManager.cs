using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        PlayMusic("Lobby");
    }

    public void DetectClick()
    {
        AudioManager.Instance.PlaySFX("");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Song not found");
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Song not found");
        }

        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }
    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }
    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }
    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }


    /*
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider soundEffectSlider;


    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        if (!PlayerPrefs.HasKey("soundVolume"))
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
            LoadSoundEffect();
        }
        else
        {
            LoadSoundEffect();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    // sound effect
    public void ChangeSoundEffectVolume()
    {
        AudioListener.volume = soundEffectSlider.value;
        SaveSoundEffect();
    }

    private void LoadSoundEffect()
    {
        soundEffectSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void SaveSoundEffect()
    {
        PlayerPrefs.SetFloat("soundVolume", soundEffectSlider.value);
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    */
}
