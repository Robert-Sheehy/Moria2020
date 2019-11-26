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

    //internal Creature createMonsterAt(Vector2Int newPosition)
    //{

    //}

    void populateMonsterList()
    {
        //                           |Name                   |Description                           |Model File Name         |Str |Dex |Int |HP    |DMG Dice |DMG Range  |Hit Bonus  |Damage Bonus   |AC
        allMonsters.Add(new Creature("Zombie",               "A mindless Zombie",                   "Zombie",                 2,   0,  -2,   20,    1,        6,          2,          2,              8));
        allMonsters.Add(new Creature("Skeleton",             "A shambling skeleton",                "n/a",                    0,   2,  -2,   10,    2,        4,          3,          2,              12));
        allMonsters.Add(new Creature("Brown Snake",          "A common brown snake",                "n/a",                    0,   2,   0,   8,     1,        4,          4,          2,              14));
        allMonsters.Add(new Creature("Kobold",               "A small, scaled Kobold",              "n/a",                    1,   1,   1,   15,    2,        4,          4,          2,              12));
        allMonsters.Add(new Creature("White Worm Mass",      "A mass of writhing worms",            "n/a",                   -1,   0,  -4,   1,     1,        2,          0,          0,              17));
        allMonsters.Add(new Creature("White Harpy",          "A white, winged harpy",               "n/a",                    1,   3,   1,   20,    1,        8,          4,          1,              15));
        allMonsters.Add(new Creature("Metallic Centipede",   "A metallic shelled centipede",        "n/a",                    1,   2,  -1,   5,     2,        4,          2,          2,              16));
        allMonsters.Add(new Creature("Red Jelly",            "A red gelatinous cube",               "n/a",                    0,   0,  -4,   26,    1,        6,          2,          0,              6));
        allMonsters.Add(new Creature("Black Naga",           "A vicious black naga",                "n/a",                    2,   4,   2,   52,    3,        6,          5,          4,              15));
        allMonsters.Add(new Creature("Goblin",               "A small, cunning goblin",             "n/a",                    0,   4,   0,   10,    3,        4,          4,          0,              12));
        allMonsters.Add(new Creature("Orc",                  "A savage, tribal orc",                "n/a",                    4,   2,   0,   24,    2,        8,          3,          2,              14));
        allMonsters.Add(new Creature("Umber Hulk",           "A large, beetle-like biped",          "n/a",                    4,   0,  -1,   38,    3,        8,          4,          0,              18));
        allMonsters.Add(new Creature("Giant Red Jelly",      "A giant, red gelatinous cube",        "n/a",                    0,   0,  -4,   82,    1,        8,          2,          2,              4));
        allMonsters.Add(new Creature("Wight",                "A soulless, undead wight",            "n/a",                    1,   2,   0,   27,    2,        6,          2,          5,              13));
        allMonsters.Add(new Creature("Orge",                 "A giant, primal orge",                "n/a",                    6,  -2,  -3,   140,   4,        8,          2,          6,              12));
        allMonsters.Add(new Creature("Red Dragon",           "A powerful, crimson hued dragon",     "n/a",                    4,   2,   4,   125,   3,        12,         2,          2,              16));
        allMonsters.Add(new Creature("Balrog",               "A terrible, relentless devil",        "n/a",                    10,  6,   8,   1100,  8,        10,         6,          10,             24));
    }
}
