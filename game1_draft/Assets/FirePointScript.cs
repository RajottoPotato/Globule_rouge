using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
   

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }

        


    }
    

    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint. rotation);
    }

}
