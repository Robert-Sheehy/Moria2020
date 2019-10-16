using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Transform WallPrefab;
    int[,] theMap;
    // Start is called before the first frame update
    void Start()
    {
        theMap = new int[100, 100];

        theMap[5, 5] = 100;
        Instantiate(WallPrefab, new Vector3(5, 0, 5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void AttemptMove(Vector3 newPosition, CharacterControl character)
    {
        if (theMap[(int)newPosition.x, (int)newPosition.z] == 1000) //1000 is a placeholder value for identifing a monster
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

    private Creature getMonsterAt(Vector3 newPosition)
    {
        throw new NotImplementedException();
    }

    internal bool CanMoveTo(Vector3 newPosition)
    {
        return theMap[(int)newPosition.x, (int)newPosition.z] < 10;
    }
}
