using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovSpd = 5;
    private float RotSpdr;
    private float RotSpdu;
    Vector3 h1;
    Vector3 v1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h1 = Vector3.right * h;
        v1 = Vector3.up * v;

        transform.position += (h1 + v1)* MovSpd*Time.deltaTime;

        RotSpdr = h * 1;
        RotSpdu = v * 1;

        transform.Rotate (0f, RotSpdr ,0f);
        transform.Rotate(RotSpdu, 0f, 0f);

        if (Input.GetKey(KeyCode.D))
        {
            MovSpd = MovSpd + Time.deltaTime * 3;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            MovSpd =5;
        }
        if (Input.GetKey(KeyCode.W))
        {
            MovSpd = MovSpd + Time.deltaTime * 3;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            MovSpd = 5;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovSpd = MovSpd + Time.deltaTime * 3;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            MovSpd = 5;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovSpd = MovSpd + Time.deltaTime * 3;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            MovSpd = 5;
        }


    }
}
