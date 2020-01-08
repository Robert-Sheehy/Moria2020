﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
  
    public static ItemsControl items;
    MonsterManager monsterManager;
    const int WORLD_WIDTH = 100, WORLD_DEPTH = 100;
    mapSpace[,] theMap;
    public static GameObject Wall;


    // Start is called before the first frame update
    void Start()
    {
        Wall = (GameObject) Resources.Load("WallPreFab");
        int currentLevel = 10;
        theMap = generateMap();

        items = FindObjectOfType<ItemsControl>();
        monsterManager = FindObjectOfType<MonsterManager>();
        theMap[5, 5] = new mapSpace(mapSpace.Immovables.Wall);

        for (int i = 0; i < 10; i++)
            generateRandomItem(currentLevel);
        Vector2Int newPosition = randomEmptyPosition();
        generateRandomCreature(1);
    //    Creature newMonster = monsterManager.createMonsterAt(newPosition);
    //    place(newMonster, newPosition);
    }

    private void place(Creature newMonster, Vector2Int newPosition)
    {
        theMap[(int)newPosition.x, (int)newPosition.y].AddMonster(newMonster);
    }

    private mapSpace[,] generateMap()
    {
       mapSpace[,] newMap =  new mapSpace[WORLD_WIDTH, WORLD_DEPTH];
        for (int i = 0; i < WORLD_WIDTH; i++)
            for (int J = 0; J < WORLD_DEPTH; J++)
            {
                newMap[i, J] = new mapSpace(mapSpace.Immovables.Space);
                newMap[i, J].youAreAt(worldPositionFor(i, J));
            }
        return newMap;
    }

    private Vector3 worldPositionFor(int i, int j)
    {
        return new Vector3(i, 0, j);
    }

    private void generateRandomItem(int currentLevel)
    {
      

        Vector2Int newItemPosition = randomEmptyPosition();


        getMapAtPosition(newItemPosition).place(items.randomItem(currentLevel));



    }

    private void generateRandomCreature(int currentLevel)
    {
        Vector2Int newCreaturePosition = randomEmptyPosition();
        theMap[(int)newCreaturePosition.x, (int)newCreaturePosition.y].AddMonster(monsterManager.randomCreature(currentLevel));
        //place(monsterManager.randomCreature(currentLevel), newCreaturePosition);
    }

    mapSpace getMapAtPosition(Vector2Int pos)
    {
        return theMap[pos.x, pos.y];
    }
    internal Vector2Int randomEmptyPosition()
    {
        Vector2Int newPosition  = new Vector2Int(UnityEngine.Random.Range(0, WORLD_WIDTH), UnityEngine.Random.Range(0, WORLD_DEPTH));
        if (getMapAtPosition(newPosition).isEmpty) return newPosition;
        return randomEmptyPosition();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector2Int v = randomEmptyPosition();
            makeVisible(new Vector3(v.x, 0, v.y), 5);
           
        }


    }


    void makeVisible(Vector3 position, float radius)
    {
        int iPos = (int)position.x;
        int jPos = (int)position.z;
        int range = (int) radius;

        for (int i = iPos - range; i < iPos + range + 1; i++) 
            for (int j = jPos - range; j < jPos + range + 1; j++) 
                if (isOnMap(i, j))
                    theMap[i, j].makeVisible();

    }

    private bool isOnMap(int i, int j)
    {
        return (i >= 0) && (j >= 0) && (i < WORLD_WIDTH) && (j < WORLD_DEPTH);
    }

    internal void AttemptMove(Vector3 newPosition, CharacterControl character)
    {
        if (theMap[(int)newPosition.x, (int)newPosition.z].containsMonster()) //1000 is a placeholder value for identifing a monster
        {
            Creature monster = getMonsterAt(newPosition);
            {
                Creature player = new Creature(character.stats);
                int isHit = Combat.HitCheck(player, monster);

                if (isHit == 0)
                {
                    Debug.Log("Attack Missed...");
                }

                if (isHit == 1)
                {
                    int damageDealt = Combat.CalcDamage(player, monster, isHit);
                    monster.damaged(damageDealt);
                    Debug.Log(damageDealt + " Damage Dealt");
                }

                if(isHit == 2)
                {
                    int damageDealt = Combat.CalcDamage(player, monster, isHit);
                    monster.damaged(damageDealt);
                    Debug.Log("Critical Hit!\n" + damageDealt + " Damage Dealt");
                }
            }
        }

    }

    internal bool monsterIsHere(Vector3 newPosition)
    {
        throw new NotImplementedException();
    }

    internal Creature getMonsterAt(Vector3 newPosition)
    {
       return  theMap[(int)newPosition.x, (int)newPosition.z].getMonster();
    }

    internal bool CanMoveTo(CharacterControl character, Vector3 newPosition)
    {
        // Check For Monster
        if (theMap[(int)newPosition.x, (int)newPosition.z].containsMonster())
        {
            int damage = registerAttack(new Creature(character.stats), theMap[(int)newPosition.x, (int) newPosition.z].getMonster());

            theMap[(int)newPosition.x, (int)newPosition.z].getMonster().damaged(damage);
        }

        return theMap[(int)newPosition.x, (int)newPosition.z].canMoveTo();
    }

    private int registerAttack(Creature creatureA, Creature CreatureB)
    {
        {
            int isHit = Combat.HitCheck(creatureA, CreatureB);

            if (isHit == 1)
            {
                int damageDealt = Combat.CalcDamage(creatureA, CreatureB, isHit);
                CreatureB.damaged(damageDealt);
                Debug.Log(damageDealt + " Damage Dealt");
                return damageDealt;
            }

            if (isHit == 2)
            {
                int damageDealt = Combat.CalcDamage(creatureA, CreatureB, isHit);
                CreatureB.damaged(damageDealt);
                Debug.Log("Critical Hit!\n" + damageDealt + " Damage Dealt");
                return damageDealt;
            }
      
            Debug.Log("Attack Missed...");
            return 0;
        }
    }
}