using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using UnityEngine;

public class MusicSelector : MonoBehaviour
{
    public AudioSource song1;
    public AudioSource song3;
    public AudioSource songScary;
    public AudioSource songScary2;
    public AudioSource TheUnnown;
    public AudioSource songPondTrack;

    public int TrackSelector;
    public int TrackHistory;

    private void Start()
    {
        
        TrackSelector = Random.Range(0, 3);
        if(TrackSelector == 0 )
        {
            song1.Play();
        } else if (TrackSelector == 1)
        {
            song3.Play();
        }
        else if (TrackSelector == 2)
        {
            TheUnnown.Play();
        }
        else if (TrackSelector == 3)
        {
            songPondTrack.Play();
        }
    }

    private void Update()
    {
        if(song1.isPlaying == false && song3.isPlaying == false && TheUnnown.isPlaying == false && songPondTrack.isPlaying == false)
            {
            TrackSelector = Random.Range(0, 3);
            if (TrackSelector == 0 && TrackHistory != 1)
            {
                song1.Play();
                TrackHistory = 1;
            }
            else if (TrackSelector == 1 && TrackHistory != 2)
            {
                song3.Play();
                TrackHistory = 2;
            }
            else if (TrackSelector == 2 && TrackHistory != 3)
            {
                TheUnnown.Play();
                TrackHistory = 3;
            }
            else if (TrackSelector == 3 && TrackHistory != 4)
            {
                songPondTrack.Play();
                TrackHistory = 4;
            }
        }
    }
}
