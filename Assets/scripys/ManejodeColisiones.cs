using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejodeColisiones : MonoBehaviour
{
   
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            Desaparecer();
        }
    }

    void Desaparecer()
    {
        Destroy(gameObject);
    }
}
