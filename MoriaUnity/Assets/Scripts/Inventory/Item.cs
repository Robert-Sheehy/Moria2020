using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item
{
    public string itemName;
    internal string ModelFilename;
    internal int itemID;


    internal string itemDesc;
    internal Texture2D itemIcon;
    internal int itemPower;
    internal int itemCost;
    internal int itemMagicLevel;
    public ItemType itemType;
    internal float itemWieght;
    internal int min_level;


    public enum ItemType
    {
        Weapom,
        Consumable,
        potion,
        armour
    }

//    public Item(string name, int id, string desc, int power, int cost, ItemType type, int weight,
//    {
//        itemName = name;
//        itemID = id;
//        itemDesc = desc;
//        itemPower = power;
//        itemIcon = Resources.Load<Texture2D>("ItemIcons/" + itemName);
//;       itemCost = cost;
//        itemType = type;
//        itemWieght = weight;
//    }

    public Item()
    {

    }

    public Item(string Name, string ModelName, float  Weight, int Level, int Cost, int magicLevel)
    {
        itemName = Name;
        ModelFilename = ModelName;
        itemWieght = Weight;
        min_level = Level;
        itemCost = Cost;
        itemMagicLevel = magicLevel;
    }
}
