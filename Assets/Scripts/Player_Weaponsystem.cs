using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Weaponsystem : MonoBehaviour
{
    public Transform slotSpawn;
    public List<Slot_Prefab> slotsSpawned;
    public GameObject slot;
    public Slot_Prefab currentSlot;
    Player_Inventory inventory;
    
    private void Start()
    {
        inventory = GetComponent<Player_Inventory>();

        for (int i = 0; i < inventory.items.Count; i++)
        {
            slotsSpawned.Add(Instantiate(slot, slotSpawn).GetComponent<Slot_Prefab>());

            slotsSpawned[i].icon.sprite = inventory.items[i].itemIcon;
            int temp = i;
            slotsSpawned[i].GetComponent<Button>().onClick.AddListener(delegate { changeWeapon(temp); });


        }

        currentSlot.icon.sprite = inventory.itemEquiped.itemIcon;
    }


    public void updateSlots()
    {
        for (int i = 0; i < inventory.items.Count; i++)
        {
            slotsSpawned[i].icon.sprite = inventory.items[i].itemIcon;
        }
        currentSlot.icon.sprite = inventory.itemEquiped.itemIcon;
    }

    public void changeWeapon(int ID)
    {
        Item_Prefab tempItem = inventory.itemEquiped;

        inventory.itemEquiped = inventory.items[ID];
        inventory.items[ID] = tempItem;

        updateSlots();
    }

    public void turnWeapons()
    {
        if (slotSpawn.gameObject.active)
        {
            slotSpawn.gameObject.SetActive(false);
        }
        else
        {
            slotSpawn.gameObject.SetActive(true);
        }
    }
}
