using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public SpriteRenderer graphic;
    public float Speed;
    private float gfxSize;
    private float initialYPos;
    private float yLimit;
    // Start is called before the first frame update
    void Start()
    {
        //guardamos lo largo que mide el gr?fico y lo multiplicamos por su escala
        gfxSize = graphic.bounds.size.y;
        //guardamos la posicion inicial
        initialYPos = transform.position.y;
        //y guardamos la cantidad de distanciona que debe recorrer el grafico antes de volver a sud posicion inicial
        yLimit = initialYPos - gfxSize;
    }

    // Update is called once per frame
    void Update()
    {
        //movemos el grafico hacia abaho
        transform.Translate(Vector3.up * Time.deltaTime * -Speed);

        //comptrobamos que el grafico haya alcanzado el limite inferior
        if (transform.position.y < yLimit)
        {
            //y lo volvemos a llevar a donde estaba inicialmente
            transform.position = new Vector3(transform.position.x, initialYPos, transform.position.z);
        }
    }
}
