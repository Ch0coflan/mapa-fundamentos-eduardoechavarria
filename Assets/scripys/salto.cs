using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
    

{
    private Rigidbody rb;
    public Vector3 gravity = new Vector3 (0f, -9.8f, 0f);
    void Start()
    {
 rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
