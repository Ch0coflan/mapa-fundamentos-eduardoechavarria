using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public GameObject sphere;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Colision")
        {
            print("posicion " + sphere.transform.position.x);

        }
    }
}
