using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public GameObject bullet;
    public float Cooldown;
    public Transform SpawnPoint;

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

        if (Input.GetKey(KeyCode.Space) && cdCounter > Cooldown)
        {
            //instanciamos (creamos) la bala
            Instantiate(bullet, SpawnPoint.position, Quaternion.identity);

            //reseteamos el cd counter a 0
            cdCounter = 0;
        };

    }
}
