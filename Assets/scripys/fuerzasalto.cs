using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerzasalto : MonoBehaviour
{
    public float fuerzaSalto = 50f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //detectar si se presiona la tecla de salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //obtener la componente rigidbody del objeto
            Rigidbody rb = GetComponent<Rigidbody>();
            //aplicar la fuerza
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
        