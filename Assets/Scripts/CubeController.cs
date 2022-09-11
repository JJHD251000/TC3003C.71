using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private AudioController audioController;
    // Start is called before the first frame update
    void Start()
    {
        audioController = FindObjectOfType<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            audioController.AudioSelect(0, 0.5f);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            audioController.AudioSelect(1, 0.5f);
        }
    }
}
