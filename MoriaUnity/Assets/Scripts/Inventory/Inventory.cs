using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int slotsX, slotsY;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();
    private ItemDatabase database;
    private bool showInventorty;
    private int itemsInInventory = 0;

    void Start()
    {
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new Item());
        }
        database = GameObject.FindGameObjectWithTag("item Database").GetComponent<ItemDatabase>();
        inventory.Add(database.items[0]);
        inventory.Add(database.items[1]);
    }

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            showInventorty = !showInventorty;
        }
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
                GUI.Box(new Rect(x * itemsInInventory, y * 1, 20,20), y.ToString());
            }
        }
    }
}
