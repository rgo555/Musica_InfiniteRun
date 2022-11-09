using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test1 : MonoBehaviour
{
    public SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        soundManager.SeleccionAudio(0);
    }
}
