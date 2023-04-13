using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour,IWeapon
{
    public float cooldown;
    public float damage;

    public GameObject projectile;

    public void useWeapon()
    {
        
    }
}
