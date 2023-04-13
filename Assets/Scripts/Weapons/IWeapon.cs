
using UnityEngine;

public interface IWeapon 
{
    public void useWeapon();
}
public interface IWeaponRange : IWeapon
{
    public void initWeapon(Transform spawnTransform);
}
