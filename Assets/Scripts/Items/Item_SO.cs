using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName ="Item")]
public class Item_SO : ScriptableObject
{

    [Header("Main")]
    public string itemName;
    public int ID;
    public int slotMaxQuantity;
    public bool canStack;
    public string description;
    public Sprite itemIcon;
    public Item.ItemType itemType;

    [Header("Shop")]
    public float priceDefault;

    [Header("World")]
    public GameObject worldObject;


}
