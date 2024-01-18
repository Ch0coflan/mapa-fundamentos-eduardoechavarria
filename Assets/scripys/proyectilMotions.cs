using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public float initialSpeed = 10f;
    public float launchAngle = 45f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        launchProjectile();
    }

    // Update is called once per frame
    void Update()
    {
   

    }

    void launchProjectile()
    {
        float launchAngleRad = launchAngle * Mathf.Deg2Rad;
        float initialVelocityX = initialSpeed * Mathf.Cos(launchAngle);
        float initialVelocityY = initialSpeed * Mathf.Sin(launchAngle);

        Vector3 initialVelocity = new Vector3(initialVelocityX, initialVelocityY, 0f);
        rb.velocity = initialVelocity;
    }
}
