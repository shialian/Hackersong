using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public static Dialogue instance;
    private AudioSource source;

    private void Start()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    public void PlayClip(AudioClip clip)
    {
        StopClip();
        source.PlayOneShot(clip);
    }

    private void StopClip()
    {
        source.Stop();
    }
}
