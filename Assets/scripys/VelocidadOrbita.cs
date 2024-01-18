using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadOrbita : MonoBehaviour
{
    public float OrbitalSpeed = 10f;
    public Transform CenterofMass;
    // Start is called before the first frame update
    void Orbit()
    {
        transform.RotateAround(CenterofMass.position, Vector3.up,OrbitalSpeed*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Orbit();
    }
}
