using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote_two : MonoBehaviour
{
    
    GameObject mySphere;

    // Start is called before the first frame update
    void Start()
    {
       //for(int i=0; i<1; i++) {
        //float px = Random.Range(0.0f,10.0f);
        //float py = Random.Range(0.0f,10.0f);
        //float pz = Random.Range(0.0f,10.0f);
        Vector3 p = new Vector3(3.0f,8.0f,2.0f);

        float cR = Random.Range(0.0f,1.0f);
        float cG = Random.Range(0.0f,1.0f);
        float cB = Random.Range(0.0f,1.0f);
        Color c = new Color(cR,cG,cB);
        createSphere(p,c);
       //} 
    }

    GameObject createSphere(Vector3 position, Color color) {
        //Create some spheres
        mySphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        mySphere.transform.localPosition = position;

        //material color
        Renderer rend = mySphere.GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Standard"));
        rend.material.SetColor("_Color", color);
        //rigidBody
        Rigidbody rb = mySphere.AddComponent<Rigidbody>();
        rb.mass = 1;
        //physicsmaterial
        PhysicMaterial mat = new PhysicMaterial();
        mat.bounciness = 1.0f;
        Collider collider=mySphere.GetComponent<Collider>();
        collider.material=mat;
        return mySphere;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

