using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1.0f;
    private float fireTimer = 0.0f;
    public float bulletSpeed = 5.0f;
    public GameObject muzzle;
    public GameObject fireEffect;

    private void Update()
    {
        fireTimer += Time.deltaTime;
        
        if (fireTimer >= 1.0f / fireRate)
        {
            Fire();
            fireTimer = 0f;
        }    
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Instantiate(muzzle, firePoint.position, firePoint.rotation);
        Instantiate(fireEffect, firePoint.position, firePoint.rotation);


        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }    
}
