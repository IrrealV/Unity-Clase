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
        transform.position = (new Vector3 (0f,0f,RSpeed) * Time.deltaTime);
    }
}