using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public Joystick rightJoystick;
    public GameObject crosshair;
    public GameObject projectile;
    public float offset;

    public float bulletsSpeed;
    public float shootCooldown;
    Vector3 crossPosition;

    private void FixedUpdate()
    {
        if(rightJoystick.Horizontal != 0 || rightJoystick.Vertical != 0)
        {

            crosshair.SetActive(true);
            
            crossPosition = new Vector3(rightJoystick.Horizontal, rightJoystick.Vertical).normalized;
            crosshair.transform.position = transform.position + crossPosition * offset;

            if (!IsInvoking("shoot"))
            {
                InvokeRepeating("shoot", shootCooldown, shootCooldown);
            }
        }
        else
        {
            crosshair.SetActive(false);
            CancelInvoke("shoot");
        }
        
    }

    public void shoot()
    {
        Rigidbody2D temp = Instantiate(projectile, crosshair.transform.position, projectile.transform.rotation).GetComponent<Rigidbody2D>();
        temp.velocity = crossPosition * bulletsSpeed;

    }
}
