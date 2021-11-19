using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lateral : MonoBehaviour
{
    public float v = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3( v, 0f, 0f) *Time.deltaTime;
    }
}
