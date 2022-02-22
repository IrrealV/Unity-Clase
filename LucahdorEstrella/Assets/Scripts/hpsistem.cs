using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpsistem : MonoBehaviour
{   
    public int MaxHP;
    public int currentHP;
    public string TagDaño ;
    public string TagVida ;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag(TagDaño))
        {
           currentHP -= 10;
         if (currentHP <= 0)
            {
                Destroy(gameObject);
                
            } 

        }

        if (collision.CompareTag(TagVida))
        {
            
            if(currentHP < MaxHP)
            {
                currentHP += 10;
                if(currentHP >= MaxHP)
                {
                    currentHP = MaxHP;
                }
                Destroy(collision.gameObject);
                Debug.Log("se ha recuperado salud");
            }
        }

        
        


    }
}
