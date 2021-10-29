using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    public TextMeshProUGUI UIText;
    public float Speed = 4;
    public Space relativeTo;
    // Start is called before the first frame update
    void Start()
    {
       // Transform.position = new Vector3(1,2,1) + new Vector3(3, 4, 1);
       //transform.position = new Vector3 (1,2,1)
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Horizontal");
        float h = Input.GetAxis("Profundidad");
        Vector3 newHPos = Vector3.right * v;
        Vector3 newVPos = Vector3.forward * h;
        //direccion (Vector tamaño 1)
        Vector3 dir = (newHPos + newVPos).normalized;
        //cambio de posición por segundo (pero en Unity nos movemos cada fotograma)
        Vector3 velocity = dir * Speed;
        //cambio de pos. por fotograma
        Vector3 displacement = velocity * Time.deltaTime;
        //movimiento acorde a un espacio de coordenadas
        transform.Translate(displacement, relativeTo);
        //Te lo digo enserio estoy muy perdido
        UIText.text = (newHPos + newVPos).ToString("F2");
    }
}
