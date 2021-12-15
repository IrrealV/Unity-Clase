using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    public float xThreshols;
    public float Speed;
    private float dir = 1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localPosition.y > 3){
            dir = -1;
        }
        if(transform.localPosition.y < -3){
            dir = 1;
        }







        transform.Translate(Vector3.up * Time.deltaTime * Speed * dir);
        



    }
}
