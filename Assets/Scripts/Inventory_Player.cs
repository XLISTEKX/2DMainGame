
using UnityEngine;

public class Inventory_Player : Inventory_Prefab
{
    public GameObject itemObject;

    private void Start()
    {
        addItem(itemObject.GetComponent<Item>());
        
    }


    public override bool addItem(Item itemToAdd, int quantity = 1)
    {
        items.Add(itemToAdd);
        return true;
    }

}
