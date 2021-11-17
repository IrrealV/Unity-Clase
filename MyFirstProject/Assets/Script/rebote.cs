using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rebote : MonoBehaviour
{
    public float RSpeed = 5;
    public float USpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(RSpeed, USpeed, 0f)* Time.deltaTime);

        if (transform.position.y >= 4f){

            USpeed = -5f;

            transform.Translate(new Vector3(RSpeed, USpeed, 0f)*Time.deltaTime);
        
        
        };

        if (transform.position.y <= 1f)
        {
            USpeed = +5f;
            transform.Translate(new Vector3(RSpeed, USpeed, 0f) * Time.deltaTime);
        }
    }
}
