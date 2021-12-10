using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    private float VSpeed = 1f;
    private float cont = 0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, VSpeed, 0f) * Time.deltaTime);
        
        if (cont >= 0 )
        {
            VSpeed = +VSpeed;
            cont = cont + 1 ;
        }
        /*if (cont  >= 5)
        {
            cont = cont - 1;
            VSpeed = -VSpeed;
        }*/
        



    }
}
