using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rotation2 : MonoBehaviour
{
    public TextMeshProUGUI UItext;
    public float RotSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(RotSpeed, 0f, 0f)*Time.deltaTime);
    }
}
