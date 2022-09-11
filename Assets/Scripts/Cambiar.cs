using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiar : MonoBehaviour
{
    private Animator CubeAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        CubeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(CubeAnimator != null) {
        if(Input.GetKeyDown(KeyCode.Space)) {
            CubeAnimator.SetBool("cambiar",true);
        }
        else {
            CubeAnimator.SetBool("cambiar",false);
        }
       } 
    }
}
