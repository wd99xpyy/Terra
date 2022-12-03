using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemonworld : MonoBehaviour
{
    public item thisItem;
    public Inventory playerInventory;

    private void OnMouseDown()
    {
        AddNewItem();
        Destroy(gameObject);
    }

    public void AddNewItem()
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
            //inventoryManager.CreateNewItem(thisItem);
        }
        thisItem.itemHeld += 1;
        inventoryManager.RefreshItem();
    }
}
