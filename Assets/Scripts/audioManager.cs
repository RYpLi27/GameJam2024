using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Header("----- Audio Source -----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("----- Audio Source -----")]
    public AudioClip pond_track;
    public AudioClip scary_track;
    public AudioClip scary2_track;
    public AudioClip song1_track;
    public AudioClip song2_track;
    public AudioClip TheUnknown_track;
    //public AudioClip ;
    //public AudioClip ;
    //public AudioClip ;
    private void Start()
    {
        musicSource.clip = song1_track;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip) 
    {
        sfxSource.PlayOneShot(clip);
    }
}
