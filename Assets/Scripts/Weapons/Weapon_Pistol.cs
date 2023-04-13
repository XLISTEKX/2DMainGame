using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Pistol : Weapon, IWeaponRange
{
    public float bulletSpeed;
    Transform spawnTransform;

    

    private void Start()
    {
        
    }
    public void initWeapon(Transform spawnTransform)
    {
        this.spawnTransform = spawnTransform;
    }
    void IWeapon.useWeapon()
    {
        Instantiate(projectile, spawnTransform);
    }
}
