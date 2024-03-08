using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate;


    private float timer;

    private void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.E) && timer >= fireRate)
        {
            timer = 0f;
            Shoot();
     
        }
        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
