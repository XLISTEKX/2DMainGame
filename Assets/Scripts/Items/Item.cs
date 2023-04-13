using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        WeaponMelee,
        WeaponRange,
        Heal,
        Buff
    }

    public Item_SO itemInfo;
    public int itemQuantity;

    public virtual void useItem()
    {
        
    }

    public virtual void useWeapon()
    {

    }

}
