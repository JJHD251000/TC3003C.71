using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] sonidos;
    private AudioSource audio;

    private void Awake() {
        audio = GetComponent<AudioSource>();
    }

    public void AudioSelect(int clip, float volume) {
        audio.Stop();
        audio.PlayOneShot(sonidos[clip], volume);
    }
}
