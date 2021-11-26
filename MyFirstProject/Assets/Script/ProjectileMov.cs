using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMov : MonoBehaviour
{
    public float Speed = 60;
    public Space relativeTo;
    public float DestroyTime;
    private void Start()
    {
        Destroy(gameObject,DestroyTime);
    }

    // Update is called once per frame
    void Update()
    { 
        //Especifica la velocidad y el movimiento automatico de la bala
        transform.Translate(Speed * Vector3.up * Time.deltaTime, relativeTo );   
    }
}