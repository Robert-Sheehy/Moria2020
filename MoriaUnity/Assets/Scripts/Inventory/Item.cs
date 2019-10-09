using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item
{
    public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public int itemPower;
    public int itemCost;
    public ItemType itemType;
    public int itemWieght;

    public enum ItemType
    {
        Weapom,
        Consumable,
        potion,
        armour
    }

    public Item(string name, int id, string desc, int power, int cost, ItemType type, int weight)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemIcon = Resources.Load<Texture2D>("ItemIcons/" + itemName);
;       itemCost = cost;
        itemType = type;
        itemWieght = weight;
    }

    public Item()
    {

    }
}
