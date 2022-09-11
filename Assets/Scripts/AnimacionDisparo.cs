using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionDisparo : MonoBehaviour
{
    private Animator GunAnimator;
    public GameObject bala;
    
    // Start is called before the first frame update
    void Start()
    {
        GunAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bala.GetComponent<Disparo>().banderaDisparo) {
            GunAnimator.SetTrigger("disparo");
        }
    }
}
