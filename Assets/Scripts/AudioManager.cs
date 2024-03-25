using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public bool muted = false;
    [Header("--- Audio Source ---")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--- Audio Clip ---")]
    public AudioClip background;
    public AudioClip button;


    void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("dont destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            print("do destroy");
            Destroy(gameObject);
        }
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