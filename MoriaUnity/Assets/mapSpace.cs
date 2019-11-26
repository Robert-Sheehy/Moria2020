using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mapSpace 

{
    public enum Immovables { Space, Open_Door, Stairs_Up, Stairs_Down, Wall, Closed_Door }

    public Immovables thisIs = Immovables.Space;



    List<Item> ItemsHere;
    CharacterControl CharacterHere;
    Creature EnemyHere;
    private bool isVisible = false;
    private Vector3 myPosition;

    public bool isEmpty { get { return thisIs == Immovables.Space; }  }

    public mapSpace(Immovables wall)
    {
        thisIs = wall;
        ItemsHere = new List<Item>();

    }

    internal bool containsMonster()
    {
        return EnemyHere != null;
    }

    internal bool canMoveTo()
    {
        if (EnemyHere != null) return false;

        return thisIs < Immovables.Wall;
    }


    internal void  makeVisible()
    {
        if (!isVisible)
        {
            isVisible = true;

            switch (thisIs)
            {
                case Immovables.Wall:
                   GameObject.Instantiate(GameManagerScript.Wall,myPosition,Quaternion.identity);

                    break;

                case Immovables.Space:

                    GameObject.Instantiate(GameManagerScript.Wall, myPosition + Vector3.down, Quaternion.identity);
                    break;


            }
            generateItemGOHere(GameManagerScript.items);
        }
    }


    private void generateItemGOHere(ItemsControl itemManager)
    {
       foreach (Item newItem in ItemsHere)
        {
            accessItem newitemScript = itemManager.createItemGO(newItem);
            newitemScript.transform.position = myPosition;
            
        }
    }

    internal Creature getMonster()
    {
        return EnemyHere;
    }
    internal void place(Item item)
    {
        ItemsHere.Add(item);

    }

    internal void youAreAt(Vector3 position)
    {
        myPosition = position;
    }

    internal void AddMonster(Creature newMonster)
    {
        EnemyHere = newMonster;
}



}
