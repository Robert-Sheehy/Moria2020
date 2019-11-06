using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{

    List<Creature> allMonsters;
    // Start is called before the first frame update
    void Start()
    {
        allMonsters = new List<Creature>();
        populateMonsterList();
        create(allMonsters[0]);
    }

    private void create(Creature creature)
    {
        GameObject itemGO = (GameObject)Instantiate(Resources.Load(creature.modelFilename));
        EnemyControl newMonster = itemGO.AddComponent<EnemyControl>();
        newMonster.youAreA(creature);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal Creature createMonsterAt(Vector2Int newPosition)
    {
        throw new NotImplementedException();
    }

    void populateMonsterList()
    {
        //                           |Name              |Description                |Model File Name         |Str |Dex |Int |HP |DMG Dice |DMG Range  |Hit Bonus  |Damage Bonus   |AC
        allMonsters.Add(new Creature("Zombie",          "Business Zombie",          "Zombie",                 3,   2,   4,   2,  4,        2,          4,          2,              4));
        allMonsters.Add(new Creature("Zombie",          "Business Zombie",          "Zombie",                 3,   2,   4,   2,  4,        2,          4,          2,              4));
    }
}
