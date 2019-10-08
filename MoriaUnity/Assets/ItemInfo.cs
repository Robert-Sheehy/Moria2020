using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    Item myInfo;
    // Start is called before the first frame update
    void Start()
    {
        myInfo = new Item("Dagger", 1, "Dagger", 8, 23, Item.ItemType.Weapom, 45);
    }

    public string getName()
    {
        return myInfo.itemName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
