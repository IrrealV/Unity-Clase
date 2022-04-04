using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilemov : MonoBehaviour
{
    public float Speed;
    public Space relativeTo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Vector3.up , relativeTo);
    }
}
