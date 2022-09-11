using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimaChange : MonoBehaviour
{
    public Animator anim;
    public KeyCode teclas, teclaAceleron;
    
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(teclas)) {
            anim.SetTrigger("run");
        }

        if(Input.GetKeyDown(teclaAceleron)) {
            anim.SetTrigger("acelerar");
        }
    }
}
