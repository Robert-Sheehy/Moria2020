using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsControl : MonoBehaviour
{
    public static List<Item> allItems;


    // Start is called before the first frame update
    void Awake()
    {
       

        allItems = new List<Item>();
        addAllItems();
  



    }
    IEnumerator delayedAccess(FloatingTextControl text, string message, Transform parent)
    {

        for (int i = 0; i < 3; i++)
        {

            if (i>1)
            {
                text.setParent(parent);
                text.setMessage(message);
                text.setColor();
            }

            yield return null;
        }
    }

    internal accessItem getRandomItem(int forLevel)
    {
      
         int randomnum = UnityEngine.Random.Range(0, allItems.Count);
        Item tryItem = allItems[randomnum];

        if (tryItem.min_level <= forLevel) 
                    return  createItemGO(tryItem);

        return getRandomItem(forLevel);






    }



    private accessItem createItemGO(Item item)
    {
        print(item.ModelFilename);
      GameObject itemGO = (GameObject)   Instantiate( Resources.Load(item.ModelFilename));
      GameObject floatingTextGO = (GameObject)Instantiate(Resources.Load("FloatingText"));
        FloatingTextControl text = floatingTextGO.GetComponent<FloatingTextControl>();

        IEnumerator doThis = delayedAccess(text, item.itemName, itemGO.transform);
        accessItem  itemcs = itemGO.AddComponent<accessItem>();
        itemcs.youAre(item);
        StartCoroutine(doThis);

        return itemcs;
    }

    void addAllItems()
    {
 //                             Name,                               ModelName,   Weight, Level, Cost, magic_Level, NumberOfDice, RangeOfDice, Magic_damage
        allItems.Add(new Weapon("Broken Sword",                     "Sword",     7.5f,   0,     24,   1,           1,             1,          -2));
        allItems.Add(new Weapon("Broken Dagger",                    "Dagger",    1.5f,   0,     0,    1,           1,             1,          -2));
        allItems.Add(new Weapon("Dagger (Misericorde)",             "Dagger",    1.5f,   0,     10,   1,           1,             4,          -2));
        allItems.Add(new Weapon("Dagger (Stiletto)",                "Dagger",    1.2f,   0,     10,   1,           1,             4,          -2));
        allItems.Add(new Weapon("Wooden Club",                      "club",      10.0f,  0,     10,   1,           1,             3,          -2));
        allItems.Add(new Weapon("Dagger (Bodkin)",                  "Dagger",    2.0f,   1,     10,   1,           1,             4,          -2));
        allItems.Add(new Weapon("Dagger (Main Gauche)",             "Dagger",    3.0f,   2,     25,   1,           1,             5,          -2));
        allItems.Add(new Weapon("Cat-o'-Nine Tails",                "?",         4.0f,   3,     14,   1,           1,             4,          -2));
        allItems.Add(new Weapon("Javelin",                          "Javalin",   3.0f,   4,     18,   1,           1,             4,          -2));
        allItems.Add(new Weapon("Rapier",                           "Rapier",    4.0f,   4,     42,   1,           1,             6,          -2));
        allItems.Add(new Weapon("Thrusting Sword (Bilbo)",          "Rapier",    8.0f,   4,     60,   1,           1,             6,          -2));
        allItems.Add(new Weapon("Sabre",                            "Rapier",    5.0f,   5,     50,   1,           1,             7,          -2));
        allItems.Add(new Weapon("Small Sword",                      "SmallSword",7.5f,   5,     48,   1,           1,             6,          -2));
        allItems.Add(new Weapon("Spear",                            "spear",     5.0f,   5,     36,   1,           1,             6,          -2));
        allItems.Add(new Weapon("Thrusting Sword (Baselard)",       "Rapier",    10.0f,  5,     80,   1,           1,             7,          -2));
        allItems.Add(new Weapon("War Hammer",                       "WarHammer", 12.0f,  5,     225,  1,           3,             3,          -2));
        allItems.Add(new Weapon("Mace",                             "mace",      12.0f,  6,     130,  1,           2,             4,          -2));
        allItems.Add(new Weapon("Backsword",                        "cutlas",    9.5f,   7,     150,  1,           1,             9,          -2));
        allItems.Add(new Weapon("Cutlass",                          "cutlas",    11.0f,  7,     85,   1,           1,             7,          -2));
        allItems.Add(new Weapon("Awl-Pike",                         "Pike",      16.0f,  8,     200,  1,           1,             8,          -2));
        allItems.Add(new Weapon("Broadsword",                       "bSword",    15.0f,  9,     255,  1,           2,             5,          -2));
        allItems.Add(new Weapon("Lance",                            "Lnace",     30.0f,  10,    230,  1,           2,             8,          -2));
        allItems.Add(new Weapon("Morningstar",                      "MStar",     15.0f,  10,    396,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Lucerne Hammer",                   "Hammer",    12.0f,  11,    376,  1,           2,             5,          -2));
        allItems.Add(new Weapon("Flail",                            "MStar",         15.0f,  12,    353,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Longsword",                        "LongSword", 13.0f,  12,    200,  1,           1,             10,         -2));
        allItems.Add(new Weapon("Battle Axe",                       "Gaxe",      17.0f,  13,    334,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Bastard Sword",                    "LongSword", 14.0f,  14,    350,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Beaked Axe",                       "beakedaxe", 18.0f,  15,    408,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Lead-filled Mace",                 "LFmace",    18.0f,  15,    502,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Pike",                             "Pike",      16.0f,  15,    358,  1,           2,             5,          -2));
        allItems.Add(new Weapon("Broad Axe",                        "broadaxe",  16.0f,  17,    304,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Fauchard",                         "Fauchard",  17.0f,  17,    376,  1,           1,             10,         -2));
        allItems.Add(new Weapon("Katana",                           "katana",    12.0f,  18,    400,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Ball and Chain",                   "MStar",         15.0f,  20,    200,  1,           2,             4,          -2));
        allItems.Add(new Weapon("Glaive",                           "Fauchard",  19.0f,  20,    363,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Halberd",                          "Hbard",     19.0f,  22,    430,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Battle Axe(Balestarius)",          "Gaxe",      18.0f,  30,    500,  1,           2,             8,          -2));
        allItems.Add(new Weapon("Two-Handed Sword(Claymore)",       "LongSword", 20.0f,  30,    775,  1,           3,             6,          -2));
        allItems.Add(new Weapon("Foil",                             "foil",      3.0f,   35,    2,    1,           1,             5,          -2));
        allItems.Add(new Weapon("Two-Handed Sword(Espadon)",        "ESsword",   18.0f,  35,    655,  1,           3,             6,          -2));
        allItems.Add(new Weapon("Executioner's Sword",              "EXsword",   26.0f,  40,    850,  1,           4,             5,          -2));
        allItems.Add(new Weapon("Two-Handed Great Flail",           "flail",     28.0f,  45,    590,  1,           3,             6,          -2));
        allItems.Add(new Weapon("Two-Handed Sword (Flamberge)",     "FMsword",   24.0f,   8,    1000, 1,           4,             5,          -2));
        allItems.Add(new Weapon("Two-Handed Sword (No-Dachi)",      "no-dachi",  20.0f,   8,    675,  1,           4,             4,          -2));
        allItems.Add(new Weapon("Two-Handed Sword (Zweihander)",    "Zsword",    28.0f,   8,    1500, 1,           4,             6,          -2));
  //                       Name                            ModelName      Weight   Level Cost   Hit AC  Slot
        allItems.Add(new Armour("Robe",                          "helmets",     2.0f,    1,    4,     0,  2,  Armour.Slots.Torso));
        allItems.Add(new Armour("Soft Leather Armour",           "helmets",     8.0f,    2,    18,    0,  4,  Armour.Slots.Torso));
        allItems.Add(new Armour("Soft Studded Armour",           "helmets",     9.0f,    3,    35,    0,  5,  Armour.Slots.Torso));
        allItems.Add(new Armour("Hard Leather Armour",           "helmets",     10.0f,   5,    55,   -1,  6,  Armour.Slots.Torso));
        allItems.Add(new Armour("Hard Studded Armour",           "helmets",     11.0f,   7,    100,  -1,  7,  Armour.Slots.Torso));
        allItems.Add(new Armour("Woven Cord Armour",             "helmets",     15.0f,   7,    45,   -1,  6,  Armour.Slots.Torso));
        allItems.Add(new Armour("Soft Leather Ring Mail Armour", "helmets",     13.0f,   10,   160,  -1,  6,  Armour.Slots.Torso));
        allItems.Add(new Armour("Hard Leather Ring Mail Armour", "helmets",     15.0f,   12,   230,  -2,  8,  Armour.Slots.Torso));
        allItems.Add(new Armour("Leather Scale Mail Armour",     "helmets",     14.0f,   14,   330,  -1,  11, Armour.Slots.Torso));
        allItems.Add(new Armour("Metal Scale Mail Armour",       "helmets",     25.0f,   24,   430,  -2,  13, Armour.Slots.Torso));
        allItems.Add(new Armour("Chain Mail Armour",             "helmets",     22.0f,   26,   530,  -2,  14, Armour.Slots.Torso));
        allItems.Add(new Armour("Rusty Chain Mail Armour",       "helmets",     22.0f,   26,   0,    -5,  14, Armour.Slots.Torso));
        allItems.Add(new Armour("Double Chain Mail Armour",      "helmets",     26.0f,   28,   630,  -2,  15, Armour.Slots.Torso));
        allItems.Add(new Armour("Augmented Chain Mail Armour",   "helmets",     27.0f,   30,   675,  -2,  16, Armour.Slots.Torso));
        allItems.Add(new Armour("Bar Chain Mial Armour",         "helmets",     28.0f,   34,   720,  -2,  18, Armour.Slots.Torso));
        allItems.Add(new Armour("Metal Brigandine Armour",       "helmets",     29.0f,   36,   775,  -3,  19, Armour.Slots.Torso));
        allItems.Add(new Armour("Laminated Armour",              "helmets",     30.0f,   38,   825,  -3,  20, Armour.Slots.Torso));
        allItems.Add(new Armour("Partial Plate Armour",          "helmets",     32.0f,   42,   900,  -3,  22, Armour.Slots.Torso));
        allItems.Add(new Armour("Metal Lamellar Armour",         "helmets",     34.0f,   44,   950,  -3,  23, Armour.Slots.Torso));
        allItems.Add(new Armour("Full Plate Armour",             "helmets",     38.0f,   48,   1050, -3,  25, Armour.Slots.Torso));
        allItems.Add(new Armour("Ribbed Plate Armour",           "helmets",     38.0f,   50,   1200, -3,  28, Armour.Slots.Torso));

        allItems.Add(new Armour("Soft Leather Cap",              "helmets",     1.0f,    2,    4,     0,  1, Armour.Slots.Head));
        allItems.Add(new Armour("Hard Leather Cap",              "helmets",     1.5f,    2,    12,    0,  2, Armour.Slots.Head));
        allItems.Add(new Armour("Metal Cap",                     "helmets",     2.0f,    7,    30,    0,  3, Armour.Slots.Head));
        allItems.Add(new Armour("Iron Helm",                     "helmets",     7.5f,    20,   75,    0,  5, Armour.Slots.Head));
        allItems.Add(new Armour("Steel Helm",                    "helmets",     6.0f,    40,   200,   0,  6, Armour.Slots.Head));
        allItems.Add(new Armour("Silver Crown",                  "helmets",     2.0f,    44,   500,   0,  0, Armour.Slots.Head));
        allItems.Add(new Armour("Golden Crown",                  "helmets",     3.0f,    47,   1000,  0,  0, Armour.Slots.Head));
        allItems.Add(new Armour("Jewel Encrusted Crown",         "helmets",     4.0f,    50,   2000,  0,  0, Armour.Slots.Head));
    
        allItems.Add(new Armour("Small Leather Shield",    "viking_shield",     5.0f,    3,    30,    0,  2, Armour.Slots.Shield));
        allItems.Add(new Armour("Medium Leather Shield",   "viking_shield",     7.5f,    8,    60,    0,  3, Armour.Slots.Shield));
        allItems.Add(new Armour("Large Leather Shield",    "viking_shield",     10.0f,   15,   120,   0,  4, Armour.Slots.Shield));
        allItems.Add(new Armour("Small Metal Shield",      "viking_shield",     6.5f,    10,   50,    0,  3, Armour.Slots.Shield));
        allItems.Add(new Armour("Medium Metal Shield",     "viking_shield",     9.0f,    20,   125,   0,  4, Armour.Slots.Shield));
        allItems.Add(new Armour("Large Metal Shield",      "viking_shield",     12.0f,   30,   200,   0,  5, Armour.Slots.Shield));

        allItems.Add(new Armour("Set of Leather Gloves",          "Bracer",     0.5f,    1,    3,     0,  1, Armour.Slots.Hands));
        allItems.Add(new Armour("Set of Gauntlets",               "Bracer",     2.5f,    12,   35,    0,  2, Armour.Slots.Hands));

        allItems.Add(new Armour("Pair of Soft Leather Shoes",    "helmets",     0.5f,    1,    4,     0,  1, Armour.Slots.Feet));
        allItems.Add(new Armour("Pair of Soft Leather Boots",    "helmets",     2.0f,    4,    7,     0,  2, Armour.Slots.Feet));
        allItems.Add(new Armour("Pair of Hard Leather Boots",    "helmets",     4.0f,    6,    12,    0,  3, Armour.Slots.Feet));
   
        allItems.Add(new Armour("Cloak",                         "helmets",     1.0f,    1,    3,     0,  1, Armour.Slots.Back));

        allItems.Add(new Armour("Aggrivate Monster",             "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Aggrivate Monster",             "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Stupidity",                     "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Stupidity",                     "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Teleportation",                 "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Teleportation",                 "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Weakness",                      "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Weakness",                      "helmets",     0.0f,    7,    0,    0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Adornment",                     "helmets",     0.0f,    7,    20,   0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Adornment",                     "helmets",     0.0f,    7,    20,   0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Adornment",                     "helmets",     0.0f,    7,    20,   0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Protection",                    "helmets",     0.0f,    7,    100,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Protection",                    "helmets",     0.0f,    7,    100,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Feather Falling",               "helmets",     0.0f,    7,    200,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Feather Falling",               "helmets",     0.0f,    7,    200,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Searching",                     "helmets",     0.0f,    7,    250,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Searching",                     "helmets",     0.0f,    7,    250,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Slow Digestion",                "helmets",     0.0f,    7,    200,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Slow Digestion",                "helmets",     0.0f,    7,    200,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Resist Cold",                   "helmets",     0.0f,    14,   250,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Resist Cold",                   "helmets",     0.0f,    14,   250,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Resist Fire",                   "helmets",     0.0f,    14,   250,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Resist Fire",                   "helmets",     0.0f,    14,   250,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Increased Damage",              "helmets",     0.0f,    20,   100,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Increased Damage",              "helmets",     0.0f,    20,   100,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Increased To-Hit",              "helmets",     0.0f,    20,   100,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Increased To-Hit",              "helmets",     0.0f,    20,   100,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Constitution",                  "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Constitution",                  "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Dexterity",                     "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Dexterity",                     "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Intelligence",                  "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Intelligence",                  "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Strength",                      "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Strength",                      "helmets",     0.0f,    30,   400,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("See Invisible",                 "helmets",     0.0f,    40,   500,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("See Invisible",                 "helmets",     0.0f,    40,   500,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Sustain Charisma",              "helmets",     0.0f,    44,   500,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Sustain Charisma",              "helmets",     0.0f,    44,   500,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Sustain Intelligence",          "helmets",     0.0f,    44,   600,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Sustain Intelligence",          "helmets",     0.0f,    44,   600,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Sustain Wisdom",                "helmets",     0.0f,    44,   600,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Sustain Wisdom",                "helmets",     0.0f,    44,   600,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Sustain Constitution",          "helmets",     0.0f,    44,   750,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Sustain Constitution",          "helmets",     0.0f,    44,   750,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Sustain Dexterity",             "helmets",     0.0f,    44,   750,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Sustain Dexterity",             "helmets",     0.0f,    44,   750,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Sustain Strength",              "helmets",     0.0f,    44,   750,  0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Sustain Strength",              "helmets",     0.0f,    44,   750,  0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("WOE",                           "helmets",     0.0f,    50,   0,    0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("WOE",                           "helmets",     0.0f,    50,   0,    0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Slaying",                       "helmets",     0.0f,    50,   1000, 0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Slaying",                       "helmets",     0.0f,    50,   1000, 0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Lordly Protection (Acid)",      "helmets",     0.0f,    50,   1200, 0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Lordly Protection (Acid)",      "helmets",     0.0f,    50,   1200, 0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Lordly Protection (Cold)",      "helmets",     0.0f,    50,   1200, 0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Lordly Protection (Cold)",      "helmets",     0.0f,    50,   1200, 0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Lordly Protection (Fire)",      "helmets",     0.0f,    50,   1200, 0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Lordly Protection (Fire)",      "helmets",     0.0f,    50,   1200, 0,   0, Armour.Slots.RightHandRing));
        allItems.Add(new Armour("Speed",                         "helmets",     0.0f,    50,   3000, 0,   0, Armour.Slots.LeftHandRing));
        allItems.Add(new Armour("Speed",                         "helmets",     0.0f,    50,   3000, 0,   0, Armour.Slots.RightHandRing));

        allItems.Add(new Armour("Torch",                          "torche",     3.0f,    0,    2,    0,   0, Armour.Slots.Torch));
    }
}
