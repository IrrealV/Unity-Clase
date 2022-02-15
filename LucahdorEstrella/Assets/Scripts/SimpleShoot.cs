using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public GameObject bullet;
    public float Cooldown;
    public Transform SpawnPoint;
    public float TD;

    private float cdCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        cdCounter = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        cdCounter += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && cdCounter > Cooldown)
        {
            //instanciamos (creamos) la bala
            GameObject b1 =Instantiate(bullet, SpawnPoint.position, Quaternion.identity);
            //destruimos la bala despues de un tiempo
            Destroy(b1, TD);
            //reseteamos el cd counter a 0
            cdCounter = 0;
        };

        if (Input.GetKey(KeyCode.M) && cdCounter > Cooldown)
        {
            //instanciamos (creamos) la bala
            GameObject b1 = Instantiate(bullet, SpawnPoint.position, Quaternion.identity);
            //destruimos la bala despues de un tiempo
            Destroy(b1, TD);
            //reseteamos el cd counter a 0
            cdCounter = 0;
        };

    }
}
