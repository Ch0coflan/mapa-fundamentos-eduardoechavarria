using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segundoejemplodefisica : MonoBehaviour
{
    private Rigidbody rb;

    public float fuerza = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //vamos a desactivar la gravedad
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);
    }
}
