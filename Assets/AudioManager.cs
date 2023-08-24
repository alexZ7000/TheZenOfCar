using System;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class AudioManager : MonoBehaviour
{
    public AudioSource[] sounds;

    private void Awake()
    {
        sounds = transform.GetComponentsInChildren<AudioSource>();
        AudioSource s = sounds.First(sound => sound.gameObject.name == "Baladinha");
        s.Play();
        s.volume= 0f;
        AudioSource t = sounds.First(sound => sound.gameObject.name == "Theme");
        t.Play();
        t.volume = 1f;
        AudioSource g = sounds.First(sound => sound.gameObject.name == "Gol");
        g.Play();
        g.volume = 0f;
        AudioSource c = sounds.First(sound => sound.gameObject.name == "Click");
        c.Play();
        c.volume = 0f;
    }

    public void Play(string name)
    {
        if (name == "Gol" | name == "Click")
        {
            AudioSource c = sounds.First(sound => sound.gameObject.name == name);
            c.Play();
            c.volume = 1f;
            AudioSource d = sounds.First(sound => sound.gameObject.name == name);
            d.Play();
            d.volume = 1f;
        }
        else
        {
            AudioSource s = sounds.First(sound => sound.gameObject.name == name);
            s.volume = 1f;
        }
    }

    public void Stop(string name)
    {
        AudioSource s = sounds.First(sound => sound.gameObject.name == name);
        s.volume = 0f;
    }
}
