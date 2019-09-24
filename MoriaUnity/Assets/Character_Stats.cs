using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stats : MonoBehaviour
{
    int maxHealth = 100;
    int minHealth = 0;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    internal void addHealth(int v)
    {
        
        currentHealth += v;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }


    }

    internal void removeHealth(int v)
    {

        currentHealth -= v;
        if (currentHealth <= minHealth)
        {
            currentHealth = minHealth;
            print("Your are dead gg mate");
        }
    }

    internal int getHealth()
    {
        return currentHealth;

    }
}
