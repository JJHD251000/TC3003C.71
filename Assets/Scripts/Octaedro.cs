//https://pastebin.com/XaFkGpNc 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octaedro : MonoBehaviour
{
    struct Shape{
        public List<Vector3> geometry;
        public List<int> topology;
    };

    void Tessellate(Shape input) {
        List<int> originalT = input.topology;
        int limit = input.topology.Count;
        for(int t=0; t < limit; t+=3) {

        Debug.Log(t);
        Debug.Log(input.topology.Count);
        Vector3 A = input.geometry[input.topology[t+0]];
        Vector3 B = input.geometry[input.topology[t+1]];
        Vector3 C = input.geometry[input.topology[t+2]];
        int ia = FindVertex(input.geometry, A);
        int ib = FindVertex(input.geometry, B);
        int ic = FindVertex(input.geometry, C);
        Vector3 o = ((A+B)/2).normalized;
        Vector3 p = ((B+C)/2).normalized;
        Vector3 q = ((A+C)/2).normalized;
        int io = FindVertex(input.geometry, o);
        int ip = FindVertex(input.geometry, p);
        int iq = FindVertex(input.geometry, q);
        if(io == -1) 
         input.geometry.Add(o);
         io = input.geometry.Count-1;
        if(ip == -1)
         input.geometry.Add(p);
         ip = input.geometry.Count-1;
        if(iq == -1)
         input.geometry.Add(q);  
         iq = input.geometry.Count-1;      

        List<int> newT = new List<int>();
        for(int i=0; i < t; i++) 
            newT.Add(originalT[i]);
        newT.Add(ia); newT.Add(io); newT.Add(iq);
        newT.Add(io); newT.Add(ib); newT.Add(ip);
        newT.Add(iq); newT.Add(ip); newT.Add(ic);
        newT.Add(io); newT.Add(ip); newT.Add(iq);
        for(int i = t+3; i < originalT.Count; i++)
            newT.Add(originalT[i]);
        input.topology.Clear(); //Reemplazamos la topologia con la versión teselada.
        for(int i=0; i < newT.Count; i++)
           input.topology.Add(newT[i]);
        t += 9;

        //int[] resultT = new int[12]{0,3,5,3,1,4,5,4,2,3,4,5};
        /*
        Shape r = new Shape();
        r.geometry = resultG;
        r.topology = resultT;
        */
        }

        //return r;
    }

    int FindVertex(List<Vector3> list, Vector3 look) {
      for(int i=0; i<list.Count; i++) {
         if(look.x == list[i].x) {
            if(look.y == list[i].y) {
               if(look.z == list[i].z) {
                  return i;
               }
            }
         }
      }
      return -1;
    }
    
    // Start is called before the first frame update
    void Start()
    {
      /*
     Shape i = new Shape();
     i.geometry = new List<Vector3>(){
        new Vector3(0,0,0),
        new Vector3(13,0,0),
        new Vector3(5,12,0)
     };
     i.topology = new List<int>{0,1,2};

     Tessellate(i);
     foreach (Vector3 v in i.geometry)
        Debug.Log(v);
     foreach(int index in i.topology)
        Debug.Log(index);
     

     Mesh myMesh = new Mesh();
     myMesh.vertices = i.geometry.ToArray();
     myMesh.triangles = i.topology.ToArray();
     myMesh.RecalculateNormals();
     MeshRenderer mr = gameObject.AddComponent<MeshRenderer>();
     mr.material = new Material(Shader.Find("Diffuse"));
     MeshFilter mf = gameObject.AddComponent<MeshFilter>();
     mf.mesh = myMesh;
     */
     
     
     Mesh myMesh = new Mesh();
     Shape i = new Shape();
     i.geometry = new List<Vector3>() {
        new Vector3(0,0,1),
        new Vector3(1,0,0),
        new Vector3(0,0,-1),
        new Vector3(-1,0,0),
        new Vector3(0,1,0),
        new Vector3(0,-1,0)
     };

     //myMesh.vertices = i.geometry.ToArray();
     i.topology = new List<int>(){0, 1, 4,
                              2, 3, 4,
                              1, 2, 4,
                              3, 0, 4,
                              
                              5, 1, 0,
                              5, 2, 1,
                              5, 3, 2,
                              5, 0, 3,
                              };
    Tessellate(i);
    Tessellate(i);
    Tessellate(i);
    myMesh.triangles = i.topology.ToArray();
    myMesh.vertices = i.geometry.ToArray();
    myMesh.RecalculateNormals();
    MeshRenderer mr = gameObject.AddComponent<MeshRenderer>();
    mr.material = new Material(Shader.Find("Diffuse"));
    MeshFilter mf = gameObject.AddComponent<MeshFilter>();
    mf.mesh = myMesh; 
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
