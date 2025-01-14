﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotManager : MonoBehaviour
{
    public AudioMixerSnapshot onPlay;
    public AudioMixerSnapshot onPause;

    private bool PauseFlag = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A)) {
        PauseFlag = true;
        Transition();
       }
       else if(Input.GetKeyDown(KeyCode.S)) {
        PauseFlag = false;
        Transition();
       }
    }

    void Transition() {
        if(PauseFlag) {
            onPause.TransitionTo(0.01f);
        }
        else {
            onPlay.TransitionTo(0.01f);
        }
    }
}
