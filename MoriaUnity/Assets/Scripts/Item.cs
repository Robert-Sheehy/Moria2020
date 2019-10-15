using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string description, title;
    public Sprite icon;
    //public Dictionary<string, int,> stats = new Dictionary<string, int>();

    public Item(int id, string title, string description, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
       // this.stats = stats;
    }
    public Item(string Title, string Description)
    {

        title = Title;
        description = Description;
    }
    public Item(Item item)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
       // this.stats = stats;
    }


}
