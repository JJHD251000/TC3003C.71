using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private new Rigidbody rigidbody;
    public float speed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        if(movimientoH != 0.0f || movimientoV != 0.0f) {
            Vector3 dir = transform.forward * movimientoH + transform.right * movimientoV;

            rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }
    }
}
