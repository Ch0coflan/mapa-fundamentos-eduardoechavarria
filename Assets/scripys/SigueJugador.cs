using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueJugador : MonoBehaviour

{
    public GameObject Jugador1;
  
    void Update()
    {
        transform.position = Jugador1.transform.position + new Vector3(0,1, 0);

    }
}

