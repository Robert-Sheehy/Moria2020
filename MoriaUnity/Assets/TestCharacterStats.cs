using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterStats : MonoBehaviour
{
    Character_Stats myTestGuy;
    // Start is called before the first frame update
    void Start()
    {
        //myTestGuy = FindObjectOfType<Character_Stats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) myTestGuy.addHealth(5);

        if (Input.GetKeyDown(KeyCode.D)) myTestGuy.removeHealth(5);

        if (Input.GetKeyDown(KeyCode.Q)) myTestGuy.increaseHealth(5);

        if (Input.GetKeyDown(KeyCode.E)) myTestGuy.decreaseHealth(5);

        if (Input.GetKeyDown(KeyCode.J)) myTestGuy.addMana(5);

        if (Input.GetKeyDown(KeyCode.L)) myTestGuy.removeMana(5);

        if (Input.GetKeyDown(KeyCode.U)) myTestGuy.increaseMana(5);

        if (Input.GetKeyDown(KeyCode.P)) myTestGuy.decreaseMana(5);

        if (Input.GetKeyDown(KeyCode.Z)) myTestGuy.addStrength(5);

        if (Input.GetKeyDown(KeyCode.X)) myTestGuy.removeStrength(5);

        if (Input.GetKeyDown(KeyCode.C)) myTestGuy.addIntell(5);

        if (Input.GetKeyDown(KeyCode.V)) myTestGuy.removeIntell(5);

        if (Input.GetKeyDown(KeyCode.B)) myTestGuy.addWis(5);

        if (Input.GetKeyDown(KeyCode.N)) myTestGuy.removeWis(5);

        if (Input.GetKeyDown(KeyCode.M)) myTestGuy.addDex(5);

        if (Input.GetKeyDown(KeyCode.Keypad1)) myTestGuy.removeDex(5);

        if (Input.GetKeyDown(KeyCode.Keypad2)) myTestGuy.addConst(5);

        if (Input.GetKeyDown(KeyCode.Keypad3)) myTestGuy.removeConst(5);

        if (Input.GetKeyDown(KeyCode.Keypad4)) myTestGuy.addCha(5);

        if (Input.GetKeyDown(KeyCode.Keypad5)) myTestGuy.removeCha(5);

        if (Input.GetKeyDown(KeyCode.Tab)) myTestGuy.addExp(100);

        if (Input.GetKeyDown(KeyCode.LeftShift)) myTestGuy.removeExp(5);



        print(myTestGuy.getMana() + " Mana");

        print(myTestGuy.getHealth() + " Health");

        print(myTestGuy.getStrength() + " Strength");

        print(myTestGuy.getIntell() + " Intell");

        print(myTestGuy.getWis() + " Wis");

        print(myTestGuy.getDex() + " Dex");

        print(myTestGuy.getConst() + " Const");

        print(myTestGuy.getCha() + " Cha");

        print(myTestGuy.getExp() + " Exp");

        print(myTestGuy.getLevel() + " Level");

    }
}
