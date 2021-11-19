using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repaso : MonoBehaviour
{
    string palabra;
    int hp = 0;
    int mp;
    bool hasMoney = false;
    Vector3 v1;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //v1 = transform.position;
        //Debug.Log(v1.magnitude);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //v1 = new Vector3(h, 0,v);
        //Es preferible tratar cada Vector (x,z,y) por separado
        v1 = Vector3.right * h + Vector3.forward * v;
        v1.Normalize();
        transform.position += v1 * Time.deltaTime * Speed;
    }
}
