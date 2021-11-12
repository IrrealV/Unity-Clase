using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rotation : MonoBehaviour
{
    public TextMeshProUGUI UItext;
    public float RotSpeed = 20;
    public Space RelativeTo;
    public float Speed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (0f, 0f, Speed)* Time.deltaTime);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 newVPos = Vector3.right * v;
        Vector3 newHPos = Vector3.up * h;

        Vector3 forwardMov = (Vector3.up * v + Vector3.right * h * Speed);
        Vector3 displacement = forwardMov * Time.deltaTime;
        transform.Translate(displacement, RelativeTo);
        displacement.Normalize();
    }
}
