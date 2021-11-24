using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMov : MonoBehaviour
{
    public float Speed = 60;
    public Space relativeTo;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Vector3.up * Time.deltaTime, relativeTo );   
    }
}
