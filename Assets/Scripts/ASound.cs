using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class ASound
{
    public string Name;

    public AudioClip Audio;
    
    public bool Repeat;

    [HideInInspector]
    public AudioSource source;
}
    
