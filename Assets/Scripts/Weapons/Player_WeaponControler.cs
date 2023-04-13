using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_WeaponControler : MonoBehaviour
{
    [SerializeField] GameObject crosshair;
    [SerializeField] Joystick rightJoystick;
    GameObject player;
    Inventory_Player inventory;

    public Weapon currentWeapon;
    float cooldown;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<Inventory_Player>();
    }

    private void Update()
    {
        if(rightJoystick.Horizontal != 0 || rightJoystick.Vertical != 0)
        {
            crosshair.SetActive(true);
            Vector3 offset = new Vector3(rightJoystick.Horizontal, rightJoystick.Vertical, 0);
            offset.Normalize();
            crosshair.transform.position = player.transform.position + offset * 2;
            if (!IsInvoking("useWeapon"))
            {
                Invoke("useWapon", currentWeapon.cooldown);
            }
        }
        else
        {
            CancelInvoke("useWeapon");
            crosshair.SetActive(false);
        }
    }
    void useWeapon()
    {
        currentWeapon.GetComponent<IWeapon>().useWeapon();
    }
}
