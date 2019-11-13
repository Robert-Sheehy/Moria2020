using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    CharacterControl thePlayer;
    internal Creature stats;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<CharacterControl>();
        Vector3 dir = Vector3.zero;
     
    }

    // Update is called once per frame
    void Update()
    {
        print(getDirection());

        if (IshouldMove()) moveMe(getDirection()); 
    }

    private void moveMe(Vector3 v)
    {
        transform.position += v;
        transform.rotation = Quaternion.LookRotation(v);
    }

    internal void youAreA(Creature creature)
    {
        stats = creature;
    }

    private bool IshouldMove()
    {
        return Input.GetKeyDown(KeyCode.Space);
       
    }

    Vector3 getDirection()
    {
        Vector3 dir = thePlayer.transform.position - transform.position;
        return unitize(dir);
    }

    private Vector3 unitize(Vector3 v)
    {
        return new Vector3(unitize(v.x), unitize(v.y), unitize(v.z));

    }

    private float unitize(float x)
    {
        float buff = 0.1f;
        if (x < -buff) return -1.0f;
        if (x > buff) return 1.0f;
        return 0.0f;


    }

    internal void reduceHealth(int damage)
    {
        stats.damaged(damage);
    }
}
