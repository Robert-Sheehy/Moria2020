using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public int slotsX, slotsY;
    public List<accessItem> inventory = new List<accessItem>();
    public List<accessItem> slots = new List<accessItem>();

    private bool showInventorty;



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
                GUI.Box(new Rect(x * 20, y * 20, 20,20), y.ToString());
            }
        }
    }


    internal void AddItem(accessItem item)
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

