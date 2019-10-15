using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int slotsX, slotsY;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();

    private bool showInventorty;

    void Start()
    {
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new Item());
        }
    

    }

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            showInventorty = !showInventorty;
        }
    }




    internal void AddItem(Item item)
    {
        inventory.Add(item);
        Debug.Log("inventory has " + inventory.Count.ToString());
    }
    internal void RemoveItemAtIndex(int index)
    {inventory.RemoveAt(index);
        Debug.Log("inventory has " + inventory.Count.ToString());
    }

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
}
