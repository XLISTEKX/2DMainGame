using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName ="Item")]
public class Item_Prefab : ScriptableObject
{
    public int slotQuantity;
    public int amount;
    public int ID;
    public float price;

    public string itemName;
    public string description;

    public Sprite itemIcon;
    public GameObject worldItem;

}
