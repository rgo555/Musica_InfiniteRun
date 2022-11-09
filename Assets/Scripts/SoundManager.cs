using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]private AudioClip[] audios;

    private AudioSource controlAudio;

    void Awake()
    {
        controlAudio = GetComponent<AudioSource>();
    }

    public void SeleccionAudio (int indice)
    {
        controlAudio.clip = audios[indice];
        controlAudio.Play();
    }
}
