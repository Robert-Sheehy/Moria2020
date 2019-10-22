using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsControl : MonoBehaviour
{
    List<Item> allItems;
    private int randomnum;

    // Start is called before the first frame update
    void Start()
    {
        randomnum = UnityEngine.Random.Range(0, 47);

        allItems = new List<Item>();
        buildItems();

        createItemGO(allItems[randomnum]);
        //transform.rotation = Quaternion.LookRotation(Vector3.forward);
        //transform.rotation = new Vector3(0.0f, 0.0f, 0.0f);

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

    private void createItemGO(Item item)
    {
        GameObject itemGO = (GameObject)   Instantiate( Resources.Load(item.ModelFilename));
        GameObject floatingTextGO = (GameObject)Instantiate(Resources.Load("FloatingText"));
        FloatingTextControl text = floatingTextGO.GetComponent<FloatingTextControl>();

        IEnumerator doThis = delayedAccess(text, item.itemName, itemGO.transform);

        StartCoroutine(doThis);
    }

    void buildItems()
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
        allItems.Add(new Weapon("Flail",                            "MStar",     15.0f,  12,    353,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Longsword",                        "LongSword", 13.0f,  12,    200,  1,           1,             10,         -2));
        allItems.Add(new Weapon("Battle Axe",                       "Gaxe",      17.0f,  13,    334,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Bastard Sword",                    "LongSword", 14.0f,  14,    350,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Beaked Axe",                       "beakedaxe", 18.0f,  15,    408,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Lead-filled Mace",                 "LFmace",    18.0f,  15,    502,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Pike",                             "Pike",      16.0f,  15,    358,  1,           2,             5,          -2));
        allItems.Add(new Weapon("Broad Axe",                        "broadaxe",  16.0f,  17,    304,  1,           2,             6,          -2));
        allItems.Add(new Weapon("Fauchard",                         "Fauchard",  17.0f,  17,    376,  1,           1,             10,         -2));
        allItems.Add(new Weapon("Katana",                           "katana",    12.0f,  18,    400,  1,           3,             4,          -2));
        allItems.Add(new Weapon("Ball and Chain",                   "MStar",     15.0f,  20,    200,  1,           2,             4,          -2));
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
    }

    void AddArmour()
    {
        allItems.Add(new Armour("Robe", "helmets", 2.0f, 1, 4, 0, 2, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Leather Cap", "helmets", 1.5f, 2, 12, 0, 2, Armour.Slots.Head));

        allItems.Add(new Armour("Small Leather Shield", "viking_shield", 5.0f, 3, 30, 0, 2, Armour.Slots.Shield));

        allItems.Add(new Armour("Soft Leather Armour", "helmets", 8.0f, 2, 18, 0, 4, Armour.Slots.Torso));

        allItems.Add(new Armour("Soft Studded Armour", "helmets", 9.0f, 3, 35, 0, 5, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Leather Armour", "helmets", 10.0f, 5, 55, -1, 6, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Studded Armour", "helmets", 11.0f, 7, 100, -1, 7, Armour.Slots.Torso));

        allItems.Add(new Armour("Woven Cord Armour", "helmets", 15.0f, 7, 45, -1, 6, Armour.Slots.Torso));

        allItems.Add(new Armour("Soft Leather Ring Mail Armour", "helmets", 13.0f, 10, 160, -1, 6, Armour.Slots.Torso));

        allItems.Add(new Armour("Hard Leather Ring Mail Armour", "helmets", 15.0f, 12, 230, -2, 8, Armour.Slots.Torso));

    }
}
