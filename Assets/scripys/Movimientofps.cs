using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientofps : MonoBehaviour
{
    [Header ("References")]
    public Camera primeraPersona;
    [Header ("General")]
    public string horizontalAxis;
    public string verticalAxis;
    public float tamanoGravedad = -20f;
    [Header ("Jump")]
    public float alturaSalto = 1.9f;
    public float cameraVerticalAngle;
    [Header ("Movement")]
    public float velocidadCaminar = 5f;
    public float velocidadCorrer = 5f;
    [Header("Rotation")]
    public float rotationSensibility = 10f;
    public string horizontalCameraAxis;
   
    Vector3 moveInput = Vector3.zero;
    Vector3 rotationInput = Vector3.zero;
    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        Moverse();
        Look();
    }

    private void Moverse()
    {
        if (characterController.isGrounded)
        {
            moveInput = new Vector3(Input.GetAxis(horizontalAxis), 0f, Input.GetAxis(verticalAxis));
            if (Input.GetButton("Sprint"))
            {
                moveInput = transform.TransformDirection(moveInput) * velocidadCorrer;
            }
            else
            {
                moveInput = transform.TransformDirection(moveInput) * velocidadCaminar;
            }
           

            /*if (Input.GetButtonDown("Jump"))
            {
                moveInput.y = Mathf.Sqrt(alturaSalto * -2f * tamanoGravedad);
            }*/

        }

        moveInput.y += tamanoGravedad * Time.deltaTime;
        characterController.Move(moveInput*Time.deltaTime);
    }
    
    private void Look()
    {
        rotationInput.x = Input.GetAxis(horizontalCameraAxis)*rotationSensibility*Time.deltaTime;

        /*rotationInput.y = Input.GetAxis("Mouse Y") * rotationSensibility * Time.deltaTime;*/

        cameraVerticalAngle = cameraVerticalAngle + rotationInput.y;
        cameraVerticalAngle = Mathf.Clamp(cameraVerticalAngle,-70,70);
        transform.Rotate(Vector3.up * rotationInput.x);
        primeraPersona.transform.localRotation = Quaternion.Euler(-cameraVerticalAngle, 0f, 0f);
    }
}
