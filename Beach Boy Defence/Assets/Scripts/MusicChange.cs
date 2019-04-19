using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour
{
    public AudioClip Music;

    public void Change()
    {
        var camera = FindObjectOfType<Camera>();

        if (camera == null)
            return;

        var child = camera.transform.GetChild(0);
        var audioSource = child.GetComponent<AudioSource>();

        if (audioSource == null)
            return;

        audioSource.Stop();
        audioSource.PlayOneShot(Music);
    }
}
