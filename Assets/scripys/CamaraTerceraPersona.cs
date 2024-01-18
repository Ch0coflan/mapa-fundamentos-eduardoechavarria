using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraPersona : MonoBehaviour
{
    private Vector2 angle = new Vector2(-90 * Mathf.Deg2Rad, 0);
    public Transform follow;
    public float distance;
    public string horizontalCameraAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        float hor = Input.GetAxis(horizontalCameraAxis);

        if (hor != 0) 
        {
            angle.x += hor * Mathf.Deg2Rad;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 orbit = new Vector3(Mathf.Cos(angle.x),0,Mathf.Sin(angle.x));
        transform.position = follow.position + orbit * distance;
        transform.rotation = Quaternion.LookRotation(follow.position - transform.position);



    }
}
