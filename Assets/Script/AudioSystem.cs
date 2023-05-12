using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    public AudioSource Audio;

    void Awake()
    {
        Audio.Play();
    }
    public void MusikOn()
    {
        Audio.Play();
    }

    public void MusikOff()
    {
        Audio.Stop();
    }
}
