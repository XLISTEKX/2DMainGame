
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Player : Inventory_Prefab
{
    [SerializeField] Transform slotsSpawnTransform;

    List<Slot_PlayerInventory> slots = new List<Slot_PlayerInventory>();

    [SerializeField] GameObject slotPrefab;
    private void Start()
    {
        items = new List<Item>(new Item[inventorySize]);

        // Initialize Slots 
        for(int i = 0; i < inventorySize; i++)
        {
            slots.Add(Instantiate(slotPrefab, slotsSpawnTransform).GetComponent<Slot_PlayerInventory>());
            slots[i].updateSlot((uint) i, items[i]);
            uint tempI = (uint) i;
            slots[i].GetComponent<Button>().onClick.AddListener( delegate {onClickSlot(tempI);});
        }
    }
    //Update all slots
    public void updateUI()
    {
        for(int i = 0; i < inventorySize; i++)
        {
            slots[i].updateSlot((uint) i, items[i]);
        }
    }
    //On click slots
    public void onClickSlot(uint ID)
    {
        Debug.Log(ID);
    }

    public override bool addItem(Item itemToAdd, int quantity = 1)
    {
        if (itemToAdd.itemInfo.canStack)
        {
            for (int i = 0; i < inventorySize; i++)
            {
                if (items[i] != null)
                {
                    if (itemToAdd.itemInfo.ID == items[i].itemInfo.ID)
                    {
                        items[i].itemQuantity += quantity;
                        updateUI();
                        return true;
                    }
                }
            }
        }

        for (int i = 0; i < inventorySize; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                items[i].itemQuantity = quantity;
                updateUI();
                return true;
            }
        }



        return false;
    }

    public bool changeItem(int currentID, int newID)
    {
        if (newID >= inventorySize) return false;

        Item tempItem = items[currentID];
        items[currentID] = items[newID];
        items[newID] = tempItem;

        slots[currentID].updateSlot((uint)currentID,items[currentID]);
        slots[newID].updateSlot((uint)newID, items[newID]);
        return true;
    }

  
}
