
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    private float maxInventoryWeight = 100f;
    public float currentInventoryWeight = 0f;

    private void Start()
    {
        while(currentInventoryWeight <= maxInventoryWeight)
        {
        /*
         *  items.Add(new Item("Spear of the gods",0,"the best spear",2,0,Item.ItemType.Weapom,2));
         *  items.Add(new Item("Godly Armour", 1, "the best Armour", 0, 0, Item.ItemType.armour,2));
         */
        }

    }
}