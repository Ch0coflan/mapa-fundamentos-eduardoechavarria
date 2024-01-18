using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueJugador2 : MonoBehaviour
{

    public GameObject Jugador2;
    // Update is called once per frame
    void Update()
    {      
            transform.position = Jugador2.transform.position;
    }
}
