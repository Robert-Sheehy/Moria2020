using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInvScipt : MonoBehaviour
{
    Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) inventory.AddItem(new Item("Dagger", "1d4"));
        if (Input.GetKeyDown(KeyCode.Z)) inventory.RemoveItemAtIndex(3);
    }
}
