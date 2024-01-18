using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientofps2 : MonoBehaviour
{
    public float velocidadCaminar = 5f;
    public float velocidadCorrer = 5f;
    public float alturaSalto = 1.9f;
    public float tamanoGravedad = -20f;

    Vector3 moveInput = Vector3.zero;
    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Moverse();
    }

    private void Moverse()
    {
        if (characterController.isGrounded)
        {
            moveInput = new Vector3(Input.GetAxis("Horizontal2"), 0f, Input.GetAxis("Vertical2"));
            if (Input.GetButton("Sprint2"))
            {
                moveInput = transform.TransformDirection(moveInput) * velocidadCorrer;
            }
            else
            {
                moveInput = transform.TransformDirection(moveInput) * velocidadCaminar;
            }


            if (Input.GetButtonDown("Jump2"))
            {
                moveInput.y = Mathf.Sqrt(alturaSalto * -2f * tamanoGravedad);
            }

        }

        moveInput.y += tamanoGravedad * Time.deltaTime;
        characterController.Move(moveInput * Time.deltaTime);
    }
}
