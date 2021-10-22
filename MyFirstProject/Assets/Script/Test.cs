using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI UItext;
    public int number = 0;
    public float hp;
    public bool b;
    public Vector3 position;


    // Start is called before the first frame update
    void Start()
    {
  
        UItext.text = position.ToString();
        Debug.Log(number * hp); 
        Debug.Log(position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola"); 
    }
}
