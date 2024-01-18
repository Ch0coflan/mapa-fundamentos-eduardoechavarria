using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primerejemplodeinercia : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //vamos a desactivar la gravedad
        rb.useGravity = false;
    }

    void Update()
    {
        //aplicar fuerza lateral al cuerpo

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 4f, ForceMode.Force);
          
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * 3f, ForceMode.Force);

        }
    }
}
