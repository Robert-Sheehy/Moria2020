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
        createItemGO(allItems[0]);
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
}
