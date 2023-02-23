using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Inventory : Inventory_Prefab
{
    public List<GameObject> itemFrameSlots;
    public Item_Prefab itemEquiped;


    private void Start()
    {
        slots = items.Count;
    }

    public override void addItem(Item_Prefab item)
    {
        for(int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
            }
        }
    }

    public void initInv()
    {
        for(int i = 0; i < items.Count; i++)
        {
            
        }
    }
}
