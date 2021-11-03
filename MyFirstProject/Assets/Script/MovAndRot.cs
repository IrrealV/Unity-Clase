using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovAndRot : MonoBehaviour
{
    public TextMeshProUGUI UIText;
    public float Speed = 5;
    public float RotSpeed = 120;
    public Space relativeTo;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 forwardMov = Vector3.forward * v * Speed;
        //cambio de posición por segundo (pero en Unity nos movemos cada fotograma)
        //cambio de pos. por fotograma
        Vector3 displacement = forwardMov * Time.deltaTime;
        //movimiento acorde a un espacio de coordenadas
        transform.Translate(displacement, relativeTo);

        Vector3 angularMov = Vector3.up * RotSpeed * Time.deltaTime * h;
        transform.Rotate(angularMov);

        //UIText.text = velocity.ToString("F2");
    }
}
