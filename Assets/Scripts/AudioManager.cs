using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [Header("--- Audio Source ---")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--- Audio Clip ---")]
    public AudioClip background;
    public AudioClip button;

    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this);
    }
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }


    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
// MAKE BUTTONS WORK FIX THE BUG WHERE EVERYTHING STOPS MAKE MORE BUTTONS PRODUCE SOUNDS