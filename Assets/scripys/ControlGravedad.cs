using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGravedad : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 gravedad = new Vector3 (0f, -9.8f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        //obtener el componente rigidbody
        rb = GetComponent<Rigidbody>();
        //deshabilitar la gravedad  de unity para utilizar la nuestra
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //aplicar nuestra propia gravedad al objeto
        rb.AddForce (gravedad, ForceMode.Acceleration);
    }
}
