using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGems : Item
{
    int Value;

    internal GoldGems(string Name, string ModelName, int value)
    {
        itemName = Name;
        ModelFilename = ModelName;
        Value = value;
        
    }

}
