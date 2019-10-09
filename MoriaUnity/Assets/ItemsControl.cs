using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsControl : MonoBehaviour
{
    
    List<Item> allItems;
    // Start is called before the first frame update
    void Start()
    {
        allItems = new List<Item>();
        buildItems();
        AddArmour();
        createItemGO(allItems[5]);
    }
    IEnumerator delayedAccess(FloatingTextControl text, string message, Transform parent)
    {

        for (int i = 0; i < 3; i++)
        {

            if (i>1)
            {

                text.setParent(parent);
                text.setMessage(message);
                text.setColor();
            }

            yield return null;
        }
    }

    private void createItemGO(Item item)
    {
      GameObject itemGO = (GameObject)   Instantiate( Resources.Load(item.ModelFilename));
      GameObject floatingTextGO = (GameObject)Instantiate(Resources.Load("FloatingText"));
        FloatingTextControl text = floatingTextGO.GetComponent<FloatingTextControl>();

        IEnumerator doThis = delayedAccess(text, item.itemName, itemGO.transform);

        StartCoroutine(doThis);



    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void buildItems()
    {
        allItems.Add(new Weapon("Broken Sword", "Sword", 7.5f, 0, 24, 1, 1, -2, -2));
        allItems.Add(new Weapon("Broken Dagger", "Dagger", 1.5f, 0, 0, 1, 1, -2, -2));
        allItems.Add(new Weapon("Broken Dagger", "Dagger", 7.5f, 0, 24, 1, 1, -2, -2));



    }

    void AddArmour()
    {
        allItems.Add(new Armour("Robe", "helmets", 2.0f, 1, 4, 0, 2, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Leather Cap", "helmets", 1.5f, 2, 12, 0, 2, Armour.Slots.Head));

        allItems.Add(new Armour("Small Leather Shield", "viking_shield", 5.0f, 3, 30, 0, 2, Armour.Slots.Shield));

        allItems.Add(new Armour("Soft Leather Armour", "helmets", 8.0f, 2, 18, 0, 4, Armour.Slots.Torso));

        allItems.Add(new Armour("Soft Studded Armour", "helmets", 9.0f, 3, 35, 0, 5, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Leather Armour", "helmets", 10.0f, 5, 55, -1, 6, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Studded Armour", "helmets", 11.0f, 7, 100, -1, 7, Armour.Slots.Torso));

        allItems.Add(new Armour("Woven Cord Armour", "helmets", 15.0f, 7, 45, -1, 6, Armour.Slots.Torso));

        allItems.Add(new Armour("Soft Leather Ring Mail Armour", "helmets", 13.0f, 10, 160, -1, 6, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Leather Ring Mail Armour", "helmets", 15.0f, 12, 230, -2, 8, Armour.Slots.Torso));

    }
}
