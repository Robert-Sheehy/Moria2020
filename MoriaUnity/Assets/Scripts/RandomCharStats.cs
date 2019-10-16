using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCharStats
{
    List<Race> AllRaces;

    public GameObject outAge;
    public GameObject outWeight;
    public GameObject outHeight;
    public GameObject outStr;
    public GameObject outCon;
    public GameObject outWis;
    public GameObject outInt;
    public GameObject outDex;
    public GameObject outChar;

    public int age;
    public int weight;
    public int height;
    public int str;
    public int con;
    public int wis;
    public int Int;
    public int dex;
    public int Char;

    public void BaseStats()
    {
        AllRaces = new List<Race>();

        AllRaces.Add(new Race("Human", 0, 0, 0, 0, 0, 0));
        AllRaces.Add(new Race("Half-Elf", -1, 1, 0, 1, -1, 1));
        AllRaces.Add(new Race("Elf", -1, 2, 1, 1, -2, 1));
        AllRaces.Add(new Race("Halfling", -2, 2, 1, 3, 1, 1));
        AllRaces.Add(new Race("Gnome", -1, 2, 0, 2, 1, -2));
        AllRaces.Add(new Race("Dwarf", 2, -3, 1, -2, 2, -3));
        AllRaces.Add(new Race("Half-Orc", 2, -1, 0, 0, 1, -4));
        AllRaces.Add(new Race("Half-Troll", 4, -4, -2, -4, 3, -6));
    }

    public void RandStats()
    {
        //str = Random.Range(8, 15) + Race.strMod;
        //con = Random.Range(8, 15) + Race.conMod;
        //wis = Random.Range(8, 15) + Race.wisMod;
        //Int = Random.Range(8, 15) + Race.IntMod;
        //dex = Random.Range(8, 15) + Race.dexMod;
        //Char = Random.Range(8, 15) + Race.CharMod;

        outStr.GetComponent<Text>().text = "" + str;
        outCon.GetComponent<Text>().text = "" + con;
        outWis.GetComponent<Text>().text = "" + wis;
        outInt.GetComponent<Text>().text = "" + Int;
        outDex.GetComponent<Text>().text = "" + dex;
        outChar.GetComponent<Text>().text = "" + Char;

    }

    public class Race
    {
        private string race;
        private int strMod;
        private int conMod;
        private int wisMod;
        private int IntMod;
        private int dexMod;
        private int CharMod;

        public Race(string race, int strMod, int conMod, int wisMod, int IntMod, int dexMod, int CharMod)
        {
            this.race = race;
            this.strMod = strMod;
            this.conMod = conMod;
            this.wisMod = wisMod;
            this.IntMod = IntMod;
            this.dexMod = dexMod;
            this.CharMod = CharMod;
        }
    }

    
    

}