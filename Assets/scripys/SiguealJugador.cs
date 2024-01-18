using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguealJugador : MonoBehaviour
{
    public GameObject Jugador;

    void Update()
    {
        transform.position = Jugador.transform.position + new Vector3(0,5,-20);
      
    }
}
