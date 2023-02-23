using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory_Prefab : MonoBehaviour
{
    public List<Item_Prefab> items;
    public int slots;

    public virtual void addItem(Item_Prefab item)
    {

    }
}
