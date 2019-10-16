using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stats { 

    int maxHealth = 100, minHealth = 0, cHealth;
    int maxMana = 100, minMana = 0, cMana;
    int maxStrength = 100, minStrength = 0, cStrength;
    int maxIntell = 100, minIntell = 0, cIntell;
    int maxDex = 100, minDex = 0, cDex;
    int maxWis = 100, minWis = 0, cWis;
    int maxConst = 100, minConst = 0, cConst;
    int maxCha = 100, minCha = 0, cCha;
    int exp;
    int maxLevel = 100, minLevel = 1, cLevel;
   
    internal void addHealth(int v)
    {
        
        cHealth += v;
        if (cHealth >= maxHealth)
        {
            cHealth = maxHealth;
        }
    }

    internal void addStrength(int v)
    {
        cStrength += v;
        if (cStrength >= maxStrength)
        {
            cStrength = maxStrength;
        }
    }

    internal void removeStrength(int v)
    {
        cStrength -= v;
        if (cStrength <= minStrength)
        {
            cStrength = minStrength;
        }
    }

    internal void addIntell(int v)
    {
        cIntell += v;
        if (cIntell >= maxIntell)
        {
            cIntell = maxIntell;
        }
    }

    internal void removeIntell(int v)
    {
        cIntell -= v;
        if (cIntell <= minIntell)
        {
            cIntell = minIntell;
        }
    }

    internal void addWis(int v)
    {
        cWis += v;
        if (cWis >= maxWis)
        {
            cWis = maxWis;
        }
    }

    internal void removeExp(int v)
    {
        exp -= v;
        if (exp <= 0)
        {
            exp = 0;
        }
    }

    internal void addExp(int v)
    {
        exp += v;
        if (exp == 100)
        {
            cLevel++;
            exp = 0;
        }

        if (cLevel >= maxLevel)
        {
            cLevel = maxLevel;
        }

    }

    internal void removeWis(int v)
    {
        cWis -= v;
        if (cWis <= minWis)
        {
            cWis = minWis;
        }
    }

    internal void addDex(int v)
    {
        cDex += v;
        if (cDex >= maxDex)
        {
            cDex = maxDex;
        }
    }

    internal void removeDex(int v)
    {
        cDex -= v;
        if (cDex <= minDex)
        {
            cDex = minDex;
        }
    }

    internal void addConst(int v)
    {
        cConst += v;
        if (cConst >= maxConst)
        {
            cConst = maxConst;
        }
    }

    internal void removeConst(int v)
    {
        cConst -= v;
        if (cConst <= minConst)
        {
            cConst = minConst;
        }
    }

    internal void addCha(int v)
    {
        cCha += v;
        if (cCha >= maxCha)
        {
            cCha = maxCha;
        }
    }

    internal void removeCha(int v)
    {
        cCha -= v;
        if (cCha <= minCha)
        {
            cCha = minCha;
        }
    }

    internal void increaseHealth(int v)
    {
        maxHealth += v;
    }

    internal void decreaseHealth(int v)
    {
        maxHealth -= v;
    }

    internal void increaseMana(int v)
    {
        maxMana += v;
    }

    internal void decreaseMana(int v)
    {
        maxMana -= v;
       
    }

    internal void removeMana(int v)
    {
        cMana -= v;
        if (cMana <= minMana)
        {
            cMana = minMana;
        }
    }

    internal void addMana(int v)
    {
        cMana += v;
        if(cMana >= maxMana)
        {
            cMana = maxMana;
        }
    }

    internal void removeHealth(int v)
    {

        cHealth -= v;
        if (cHealth <= minHealth)
        {
            cHealth = minHealth;
            //print("Your are dead, gg mate");
        }
    }

    internal int getMana()
    {
        return cMana;
    }

    internal int getHealth()
    {
        return cHealth;

    }

    internal int getStrength()
    {
        return cStrength;

    }

    internal int getIntell()
    {
        return cIntell;

    }

    internal int getWis()
    {
        return cWis;

    }

    internal int getDex()
    {
        return cDex;

    }

    internal int getConst()
    {
        return cConst;

    }

    internal int getCha()
    {
        return cCha;

    }

    internal int getExp()
    {
        return exp;
    }

    internal int getLevel()
    {
        return cLevel;
    }

}
