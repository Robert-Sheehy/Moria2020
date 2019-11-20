using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Transform WallPrefab;
    ItemsControl items;
    MonsterManager monsterManager;
    const int WORLD_WIDTH = 100, WORLD_DEPTH = 100;
    mapSpace[,] theMap;


    // Start is called before the first frame update
    void Start()
    {
        int currentLevel = 10;
        theMap = generateMap();

        items = FindObjectOfType<ItemsControl>();
        monsterManager = FindObjectOfType<MonsterManager>();
        theMap[5, 5] = new mapSpace(mapSpace.Immovables.Wall);
        Instantiate(WallPrefab, new Vector3(5, 0, 5), Quaternion.identity);
        for (int i = 0; i < 10; i++)
        generateRandomItem(currentLevel);
        Vector2Int newPosition = randomPosition();
        Creature newMonster = monsterManager.createMonsterAt(newPosition);
        place(newMonster, newPosition);
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
                newMap[i, J] = new mapSpace(mapSpace.Immovables.Space);

        return newMap;
    }

    private void generateRandomItem(int currentLevel)
    {
      

        Vector2Int newItemPosition = randomPosition();

        //theMap[newItemPosition.x, newItemPosition.y].place(items.randomItem(currentLevel));


    }

    internal Vector2Int randomPosition()
    {
        return new Vector2Int(UnityEngine.Random.Range(0, WORLD_WIDTH), UnityEngine.Random.Range(0, WORLD_DEPTH));

    }

    // Update is called once per frame
    void Update()
    {
        
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