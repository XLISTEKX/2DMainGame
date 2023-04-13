using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


public class Slot_PlayerInventory : Slot_Prefab, IDropHandler
{
    public uint slotID;
    public TMP_Text slotQuantityText;

    Inventory_Player inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory_Player>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<Slot_Item_Drag>().resetPosition();
        inventory.changeItem((int)eventData.pointerDrag.GetComponentInParent<Slot_PlayerInventory>().slotID, (int)slotID);
    }

    public void updateSlot(uint slotID, Item item = null)
    {
        this.slotID = slotID;

        if(item == null)
        {
            icon.gameObject.SetActive(false);
            slotQuantityText.gameObject.SetActive(false);
            return;
        }
        icon.gameObject.SetActive(true);
        icon.sprite = item.itemInfo.itemIcon;

        if (item.itemInfo.canStack)
        {
            slotQuantityText.text = item.itemQuantity.ToString();
            slotQuantityText.gameObject.SetActive(true);
        }
        else
        {
            slotQuantityText.gameObject.SetActive(false);
        }
        
    }

    
   
}
