using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0,100)]
    public float MaxSpeed, MaxAcceleration;
    [Header("Bounds")]
    public float HorizontalLimit;
    public float VerticalLimits;


    private float currentVelocityX, currentVelocityY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Movimiento
        Vector3 dir = new Vector3(h, v).normalized;
        transform.Translate(dir* MaxSpeed* Time.deltaTime);


        //Limites
        float xClamped = Mathf.Clamp(transform.position.x, -HorizontalLimit, HorizontalLimit);
        float yClamped = Mathf.Clamp(transform.position.y, -VerticalLimits, VerticalLimits);

        transform.position = new Vector3(xClamped, yClamped);
    }
}
