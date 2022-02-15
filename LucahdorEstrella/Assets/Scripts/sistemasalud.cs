using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemasalud : MonoBehaviour
{
    public int MaxHP;

    private int CurrentHP;

    // Start is called before the first frame update
    void Start()
    {
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Bullet"))
        {
            Debug.Log("Ha entrado en contacto");
        }
    }
}
