using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Item> inv_List;
    // Start is called before the first frame update
    void Start()
    {
        inv_List = new List<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void AddItem(Item item)
    {
        inv_List.Add(item);
        Debug.Log("inventory has " + inv_List.Count.ToString());
    }
    internal void RemoveItemAtIndex(int index)
    {
        inv_List.RemoveAt(index);
        Debug.Log("inventory has " + inv_List.Count.ToString());
    }
}
