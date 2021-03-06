using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    public TextMeshProUGUI UIText;
    public float Speed = 5;
    public Space relativeTo;
    public float SpeedX = 5;
    public float SpeedY = 3;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Horizontal");
        float h = Input.GetAxisRaw("Vertical");
        Vector3 newVPos = Vector3.right * v;
        Vector3 newHPos = Vector3.up * h;
        //direccion (Vector tama?o 1)
        Vector3 dir = (newHPos + newVPos);
        //cambio de posici?n por segundo (pero en Unity nos movemos cada fotograma)
        Vector3 velocity = dir * Speed;
        //cambio de pos. por fotograma
        Vector3 displacement = velocity * Time.deltaTime;
        //movimiento acorde a un espacio de coordenadas
        transform.Translate(displacement, relativeTo);
        
        UIText.text = velocity.ToString("F2");
    }
}
