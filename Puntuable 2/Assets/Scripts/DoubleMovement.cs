using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleMovement : MonoBehaviour
{
    public float Speed;
    Vector3 Vm;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vm = Vector3.right * h + Vector3.up * v;
        Vm.Normalize();
        transform.position += Vm * Speed * Time.deltaTime;



    if (transform.position.x > 10 & transform.position.x < 20 & transform.position.y < 10)
        {          
            transform.position += Vm * (Speed * 2) * Time.deltaTime;

        }









    }
}
