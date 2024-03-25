using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{

    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SFXSlider;
    

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }

        if (!PlayerPrefs.HasKey("muted"))
        {

            PlayerPrefs.SetInt("muted", 0);
        }
        LoadMasterVolume();


    }

    private void Update()
    {
        float vol;
        vol = musicSlider.value;
        PlayerPrefs.SetFloat("musicVolume", vol);

        if (AudioManager.instance.muted)
           vol = 0.0001f;

        print("mvol=" + vol);

        myMixer.SetFloat("music", Mathf.Log10(vol) * 20 );
        


        //
        //PlayerPrefs.SetFloat("SFXVolume", volume);
        //myMixer.SetFloat("SFX", Mathf.Log10(SFXSlider.value) * 20);
    }

    public void ToggleMusic()
    {
        print("Saving master vol");
        if (AudioManager.instance.muted == false)
        {
            AudioManager.instance.muted = true;
        }
        else
        {
            AudioManager.instance.muted = false;
        }
        SaveMasterVolume();
    }



    public void SetMusicVolume()
    {
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        
        
    }

    private void SaveMasterVolume()
    {
        PlayerPrefs.SetInt("muted", AudioManager.instance.muted ? 1 : 0);
    }

    private void LoadMasterVolume()
    {
        if( PlayerPrefs.GetInt("muted") == 0 )
        {
            AudioManager.instance.muted = false;
        }
        else
        {
            AudioManager.instance.muted = true;
        }
        

    }

    private void LoadVolume()
    {
        print("loading vol");
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        

        SetMusicVolume();
        SetSFXVolume();
    }
}
