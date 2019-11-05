using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public int slotsX, slotsY;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();

    private bool showInventorty;
    private int itemsInInventory = 0;



    private void OnGUI()
    {
        if(showInventorty)
        {
            DrawInventory();
        }
    }

    void DrawInventory ()
    {
        for(int x = 0; x < slotsX; x++)
        {
            for(int y = 0; y < slotsY; y++)
            {
                GUI.Box(new Rect(x * itemsInInventory, y * 1, 20,20), y.ToString());
            }
        }
    }


    internal void AddItem(Item item)
    {
        inventory.Add(item);
        Debug.Log("inventory has " + inventory.Count.ToString());
    }
    internal void RemoveItemAtIndex(int index)
    {
        inventory.RemoveAt(index);
        Debug.Log("inventory has " + inventory.Count.ToString());
    }
}

