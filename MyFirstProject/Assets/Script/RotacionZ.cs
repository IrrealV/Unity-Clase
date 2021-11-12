using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    public class RotacionZ : MonoBehaviour

{
    public float Speed = 5;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Este codigo hace que se mueva por teclado
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        

        if (h > 0 && v > 0) 
        {
            return;
        }


        Vector3 displacement = (Vector3.right * h + Vector3.up * v);
         

        displacement.Normalize();
        transform.Rotate( displacement * 3);

       

        text.text = transform.position.ToString();
       
    }
}
