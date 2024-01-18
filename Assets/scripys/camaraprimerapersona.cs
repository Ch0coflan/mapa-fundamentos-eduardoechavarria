using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraprimerapersona : MonoBehaviour
{
    public float velocidad;
    public Vector2 sensitivity;
    public new Transform camera;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void MovimientoBola()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 velocity = Vector3.zero;

        if (movimientoHorizontal != 0 || movimientoVertical != 0)
        {
            Vector3 direction = (transform.forward * movimientoVertical + transform.right * movimientoHorizontal).normalized;

            velocity = direction * velocidad;
        }
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;
       /* Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        GetComponent<Rigidbody>().AddForce(movimiento * velocidad);*/
    }

    void MovimientoCamara()
    {
        float CamHorizontal = Input.GetAxis("Mouse X");
        float CamVertical = Input.GetAxis("Mouse Y");

        if (CamHorizontal != 0) 
        {
            transform.Rotate(0, CamHorizontal,sensitivity.x, 0);
        }

        if ( CamVertical != 0)
        {
            Vector3 rotation = camera.localEulerAngles;
            rotation.x = (rotation.x - CamVertical * sensitivity.y + 360) % 360;

            if (rotation.x > 80 && rotation.x < 180)
            {
                rotation.x = 80;
            } else if (rotation.x < 280 && rotation.x > 180)
            {
                rotation.x = 280;
            }
            camera.localEulerAngles = rotation;

        }
    }
    void Update()
    {
      MovimientoBola();
        MovimientoCamara();
    }
}
