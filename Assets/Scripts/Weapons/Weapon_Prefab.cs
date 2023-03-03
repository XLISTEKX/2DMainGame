using UnityEngine;

public class Weapon_Prefab : MonoBehaviour
{
    public GameObject projectile;

    public float damage;
    public float bulletSpeed;
    public float reloadTime;
    public int projectileCount;
    public bool isMelee;



    public virtual void useWeapon(Vector3 direction, Vector3 spawnPoint)
    {

    }

}
