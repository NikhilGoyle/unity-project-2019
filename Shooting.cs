using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 15f;
    public float dirX, dirY;

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Jump")) 
        {
            Rotate();
            Shoot();
        }
        
    }

    void Rotate()
    {
        if (dirX == 0 && dirY == 1)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, 0);
        }
        if (dirX == 1 && dirY == 1)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -45f);
        }
        if (dirX == 1 && dirY == 0)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -90f);
        }
        if (dirX == 1 && dirY == -1)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -135f);
        }
        if (dirX == 0 && dirY == -1)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -180f);
        }
        if (dirX == -1 && dirY == -1)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -225f);
        }
        if (dirX == -1 && dirY == 0)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -270f);
        }
        if (dirX == -1 && dirY == 1)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, -315f);
        }
        if (dirX == 0 && dirY == 0)
        {
            firePoint.rotation = Quaternion.Euler(0f, 0f, 0);
        }

    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }


}
