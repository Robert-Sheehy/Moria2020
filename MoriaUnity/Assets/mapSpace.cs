using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapSpace 
{
public  enum Immovables { Space, Open_Door, Stairs_Up, Stairs_Down, Wall, Closed_Door}

   public   Immovables thisIs = Immovables.Space;



    List<Item> ItemsHere;
    CharacterControl CharacterHere;
    EnemyControl EnemyHere;

    public mapSpace(Immovables wall)
    {
        thisIs = wall;
        ItemsHere = new List<Item>();

    }

    internal bool containsMonster()
    {
        throw new NotImplementedException();
    }

    internal bool canMoveTo()
    {
        if (EnemyHere != null) return false;

        return thisIs < Immovables.Wall;
    }

    internal EnemyControl getMonster()
    {
        return EnemyHere;
    }

    internal void place(Item item)
    {
        ItemsHere.Add(item);
    }
}
