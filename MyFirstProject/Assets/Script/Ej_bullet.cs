using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_bullet : MonoBehaviour
{
    Vector3 v1;
    public float Speed;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        v1=Vector3.right * h + Vector3.up * v;
        v1.Normalize();
        transform.position += v1 * Time.deltaTime * Speed;

        if (Input.GetKey(KeyCode.Space))
        {
           Instantiate(bullet, transform.position, Quaternion.identity);
        };

        

    }
}
