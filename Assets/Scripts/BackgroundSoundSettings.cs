using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class BackgroundSoundSettings : MonoBehaviour
{
    public  AudioMixer backgroundMixer;
    public  AudioMixer effectMixer;

    public void SetVolume(float volume)
    {
        backgroundMixer.SetFloat("volume", volume);
    } 
    public void SetEffectsVolume(float vol)
    {
        effectMixer.SetFloat("vol", vol);
    } 
}
  