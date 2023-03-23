using System.Collections.Generic;
using UnityEngine;

public class Inventory_Prefab : MonoBehaviour
{
    public List<Item> items;

    public virtual bool addItem(Item itemToAdd, int quantity = 1)
    {
        return false;
    }
}
