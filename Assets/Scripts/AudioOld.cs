/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;

public class A : MonoBehaviour
{
    [SerializeField] private AudioMixer MyMixer;
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SFXSlider;

   


    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this);
    }

    private void Start()
    {

        if(PlayerPrefs.HasKey("MusicSlider"))
        {
            load();
        }
        else
        {
            SetMusicSlider();
            SetSFXSlider();
        }
    }
    public void SetMusicSlider()
    {
        float volume = MusicSlider.value;
        MyMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicSlider", volume);
    }

    public void SetSFXSlider()
    {
        float volume = SFXSlider.value;
        MyMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXSlider", volume);
    }

    private void load()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFXSlider");
        MusicSlider.value = PlayerPrefs.GetFloat("MusicSlider");
    }





}
*/