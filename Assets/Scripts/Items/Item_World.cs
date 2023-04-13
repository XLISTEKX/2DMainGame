using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_World : MonoBehaviour, IInteractable
{
    Inventory_Player inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory_Player>();
    }

    public void Interact()
    {
        Item item = GetComponent<Item>();

        inventory.addItem(item.itemInfo.worldObject.GetComponent<Item>(), item.itemQuantity);
        Destroy(gameObject);
    }
}
