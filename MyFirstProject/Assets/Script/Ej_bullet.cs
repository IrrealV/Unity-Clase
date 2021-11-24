using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_bullet : MonoBehaviour
{
    Vector3 v1;
    public float Speed;
    public GameObject bullet;
    public Transform Ca�on1, Ca�on2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //Script de movimiento
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        v1=Vector3.right * h + Vector3.up * v;
        v1.Normalize();
        transform.position += v1 * Time.deltaTime * Speed;


        //Esto sirve para disparar cuando pulses la tecla Espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go1 = Instantiate(bullet, Ca�on1.position, bullet.transform.rotation);
            GameObject go2 = Instantiate(bullet, Ca�on2.position, bullet.transform.rotation);
            Destroy(go1, 1);
            Destroy(go2, 1);
        };


        //Esto sirve para disparar mientras mantienes pulsado la letra M
        if (Input.GetKey(KeyCode.M))
        {
            GameObject go = Instantiate(bullet, Ca�on1.position, bullet.transform.rotation);
            Destroy(go, 1);
            GameObject go2 = Instantiate(bullet, Ca�on2.position, bullet.transform.rotation);
            Destroy(go2, 1);
        };



    }
}
