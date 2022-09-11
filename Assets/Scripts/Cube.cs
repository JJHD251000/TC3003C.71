using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Mesh myMesh = new Mesh();
       Vector3[] vertices = new Vector3[]{
        new Vector3(0,0,0),
        new Vector3(5,0,0),
        new Vector3(5,5,0),
        new Vector3(0,5,0),
        new Vector3(0,5,5),
        new Vector3(0,0,5),
        new Vector3(5,0,5),
        new Vector3(5,5,5)
       };

       myMesh.vertices = vertices;
       int[] square = new int[]{0,1,2, 2,3,0, 5,6,7, 7,4,5, 6,1,2, 2,7,6, 0,5,4, 4,3,0, 4,7,2, 2,3,4, 5,6,1, 1,0,5};
       myMesh.triangles = square;
       myMesh.RecalculateNormals();
       MeshFilter mf = gameObject.AddComponent<MeshFilter>();
       MeshRenderer mr = gameObject.AddComponent<MeshRenderer>(); 
       mf.mesh = myMesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
