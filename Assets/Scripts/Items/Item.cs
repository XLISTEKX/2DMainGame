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

    public virtual void useItem()
    {
        Instantiate(gameObject);
    }

}
