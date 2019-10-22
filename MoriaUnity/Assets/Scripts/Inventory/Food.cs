using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Item
{
  
    int food;

    internal Food(string Name, string ModelName, int Level, int Cost, int Food)
    {
        itemName = Name;
        ModelFilename = ModelName;   
        min_level = Level;
        itemCost = Cost;
        food = Food;
    }





}
}
