using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterStats : MonoBehaviour
{
    Character_Stats myTestGuy;
    // Start is called before the first frame update
    void Start()
    {
        myTestGuy = FindObjectOfType<Character_Stats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) myTestGuy.addHealth(5);

        if (Input.GetKeyDown(KeyCode.D)) myTestGuy.removeHealth(5);

        print(myTestGuy.getHealth());
    }
}
