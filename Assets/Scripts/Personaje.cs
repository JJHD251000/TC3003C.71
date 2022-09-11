using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private audioManager audioManager;
    // Start is called before the first frame update
    void Awake()
    {
        audioManager = FindObjectOfType<audioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            audioManager.AudioSelect(0, 0.1f);

        }
        if(Input.GetKeyDown(KeyCode.R)) {
            audioManager.AudioSelect(1, 0.1f);
        }
        if(Input.GetKeyDown(KeyCode.T)) {
            audioManager.AudioSelect(2, 0.1f);

        }
        if(Input.GetKeyDown(KeyCode.Y)) {
            audioManager.AudioSelect(3, 0.1f);
        }
    }
}
