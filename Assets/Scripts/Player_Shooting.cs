using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public Joystick rightJoystick;
    public GameObject crosshair;
    public float offsetCrosshair;

    Vector3 crossPosition;
    public Weapon_Prefab currentWeapon;


    private void Start()
    {
        currentWeapon = GetComponent<Player_Inventory>().itemEquiped.worldItem.GetComponent<Weapon_Prefab>();
    }

    private void FixedUpdate()
    {
        if(rightJoystick.Horizontal != 0 || rightJoystick.Vertical != 0)
        {

            crosshair.SetActive(true);
            
            crossPosition = new Vector3(rightJoystick.Horizontal, rightJoystick.Vertical).normalized;
            crosshair.transform.position = transform.position + crossPosition * offsetCrosshair;
            if (!IsInvoking("useWeapon"))
            {
                InvokeRepeating("useWeapon", currentWeapon.reloadTime, currentWeapon.reloadTime);
            }
            
        }
        else
        {
            crosshair.SetActive(false);
            CancelInvoke("useWeapon");
        }
        
    }

    public void useWeapon()
    {
        currentWeapon.useWeapon(crossPosition, crosshair.transform.position);
    }

}
