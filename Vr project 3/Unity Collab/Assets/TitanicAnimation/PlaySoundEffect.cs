using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundEffect : MonoBehaviour
{
    void Start()
    {
       
    }
	public void Startsound (float theValue) {
     AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
}
}
