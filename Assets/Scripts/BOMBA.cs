using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOMBA : MonoBehaviour
{
    public float espera;
    bool exploto = false;
    public float radioExplosion = 6f;
    public float fuerza = 500f;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        espera = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        espera -= Time.deltaTime;
        if(espera <= 0f && !exploto) {
            exploto = true;
            explotar();
        }
    }

    void explotar() {
        //explotar efecto
        Instantiate(explosion, transform.position, transform.rotation);
        //mover cercanos
        Collider[] col=Physics.OverlapSphere(transform.position,radioExplosion);
        foreach(Collider cercano in col) {
            //fuerza
            Rigidbody rb = cercano.GetComponent<Rigidbody>();
            if(rb != null) {
                rb.AddExplosionForce(fuerza,transform.position,radioExplosion);
            }
        }
        //eliminar esfera
        Destroy(gameObject);
        Destroy(GameObject.Find("BigExplosionEffect(Clone)"), 3f);
    }
}
