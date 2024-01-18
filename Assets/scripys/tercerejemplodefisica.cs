using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tercerejemplodefisica : MonoBehaviour
{
    public GameObject Cube;

    void Start()
    {
      //para quitarle la gravedad al cubo
      Rigidbody CubeRb = Cube.GetComponent<Rigidbody>();
        CubeRb.useGravity = true;

        //Impulsar la esfera hacia la pared al inicio
        GetComponent<Rigidbody>().AddForce(Vector3.forward *10f, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Fuerza de reaccion: " + collision.impulse.magnitude);
    }
    // Update is called once per frame
    void Update()
    {
        //imprimir la fuerza de reaccion en la consola
       
    }
}
