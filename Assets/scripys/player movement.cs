using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public string horizontalAxis;
    public string verticalAxis;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw(horizontalAxis);
        float vertical= Input.GetAxisRaw(verticalAxis);
        
        Vector3 direction = new Vector3(horizontal, vertical, 0) * speed;
        transform.Translate(direction);
    }
}
