using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_BasePistol : Weapon_Prefab
{


    public override void useWeapon(Vector3 direction, Vector3 spawnPoint)
    {
        Rigidbody2D tempRB = Instantiate(projectile, spawnPoint, projectile.transform.rotation).GetComponent<Rigidbody2D>();
        tempRB.velocity = direction * bulletSpeed;
    }
}
