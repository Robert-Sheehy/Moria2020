using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCharStats : MonoBehaviour
{
    List<Race> AllRaces;

    public GameObject outAge;
    public GameObject outWeight;
    public GameObject outHeight;
    public GameObject outSocial;
    public GameObject outStr;
    public GameObject outCon;
    public GameObject outWis;
    public GameObject outInt;
    public GameObject outDex;
    public GameObject outChar;
    public GameObject inRace;
    public GameObject genButton;

    public int age;
    public int weight;
    public int height;
    public int social;
    public int str;
    public int con;
    public int wis;
    public int Int;
    public int dex;
    public int Char;

    public int RaceChoice()
    {
        return inRace.GetComponent<Dropdown>().value; 
    }

    public void BaseStats()
    {
        AllRaces = new List<Race>();

        AllRaces.Add(new Race("Human", 0, 0, 0, 0, 0, 0, 0, 0, 2));
        AllRaces.Add(new Race("Half-Elf", -1, 1, 0, 1, -1, 1, -5, 0, -10));
        AllRaces.Add(new Race("Elf", -1, 2, 1, 1, -2, 1, -10, 0, 5));
        AllRaces.Add(new Race("Halfling", -2, 2, 1, 3, 1, 1, -3, -5, -15));
        AllRaces.Add(new Race("Gnome", -1, 2, 0, 2, 1, -2, -20, -40, -10));
        AllRaces.Add(new Race("Dwarf", 2, -3, 1, -2, 2, -3, -20, -40, 0));
        AllRaces.Add(new Race("Half-Orc", 2, -1, 0, 0, 1, -4, 4, 5, -20));
        AllRaces.Add(new Race("Half-Troll", 4, -4, -2, -4, 3, -6, 20, 20, -15));
    }

    public void RandStats()
    {
        int race = RaceChoice();
        BaseStats();

        age = Random.Range(17, 50);
        weight = Random.Range(60, 120) + AllRaces[race].weightMod;
        height = Random.Range(140, 200) + AllRaces[race].heightMod;
        social = Random.Range(40, 90) + AllRaces[race].socialMod;
        str = Random.Range(8, 15) + AllRaces[race].strMod;
        con = Random.Range(8, 15) + AllRaces[race].conMod;
        wis = Random.Range(8, 15) + AllRaces[race].wisMod;
        Int = Random.Range(8, 15) + AllRaces[race].IntMod;
        dex = Random.Range(8, 15) + AllRaces[race].dexMod;
        Char = Random.Range(8, 15) + AllRaces[race].CharMod;

        outAge.GetComponent<Text>().text = "" + age;
        outWeight.GetComponent<Text>().text = "" + weight;
        outHeight.GetComponent<Text>().text = "" + height;
        outSocial.GetComponent<Text>().text = "" + social;
        outStr.GetComponent<Text>().text = "" + str;
        outCon.GetComponent<Text>().text = "" + con;
        outWis.GetComponent<Text>().text = "" + wis;
        outInt.GetComponent<Text>().text = "" + Int;
        outDex.GetComponent<Text>().text = "" + dex;
        outChar.GetComponent<Text>().text = "" + Char;

    }

    public class Race
    {
        internal string race;
        internal int weightMod;
        internal int heightMod;
        internal int socialMod;
        internal int strMod;
        internal int conMod;
        internal int wisMod;
        internal int IntMod;
        internal int dexMod;
        internal int CharMod;

        public Race(string race, int strMod, int conMod, int wisMod, int IntMod, 
            int dexMod, int CharMod, int weightMod, int heightMod, int socialMod)
        {
            this.race = race;
            this.weightMod = weightMod;
            this.heightMod = heightMod;
            this.socialMod = socialMod;
            this.strMod = strMod;
            this.conMod = conMod;
            this.wisMod = wisMod;
            this.IntMod = IntMod;
            this.dexMod = dexMod;
            this.CharMod = CharMod;
        }
    }
}