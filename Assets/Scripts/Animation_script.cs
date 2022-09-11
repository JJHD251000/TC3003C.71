using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_script : MonoBehaviour
{
    GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
       cambiaColor(); 
    }

    void cambiaColor() {
        //Create some spheres
        cube = GameObject.Find("Cube");

        //material color
        float cR = Random.Range(0.0f,1.0f);
        float cG = Random.Range(0.0f,1.0f);
        float cB = Random.Range(0.0f,1.0f);
        Color c = new Color(cR, cG, cB);
        Renderer rend = cube.GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Standard"));
        rend.material.SetColor("_Color", c);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
