using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    internal Character_Stats stats;
    GameManagerScript theManager;
    TurnTimer food;
    // Start is called before the first frame update
    void Start()
    {
        theManager = FindObjectOfType<GameManagerScript>();
        food = new TurnTimer(3000);
        

    }

    // Update is called once per frame
    void Update()
    {
        //arrowkey control for tenkeyless
        Vector3 direction = Vector3.zero;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            direction = new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            direction = new Vector3(0, 0, -1);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            direction = new Vector3(-1, 0, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            direction = new Vector3(1, 0, 0);

//classic numpad control
        if (Input.GetKeyDown(KeyCode.Keypad8))
            direction = new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.Keypad2))
            direction = new Vector3(0, 0, -1);
        if (Input.GetKeyDown(KeyCode.Keypad4))
            direction = new Vector3(-1, 0, 0);
        if (Input.GetKeyDown(KeyCode.Keypad6))
            direction = new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.Keypad7))
            direction = new Vector3(-1, 0, 1);           
        if (Input.GetKeyDown(KeyCode.Keypad9))
            direction = new Vector3(1, 0, 1);
        if (Input.GetKeyDown(KeyCode.Keypad1))
            direction = new Vector3(-1, 0, -1);
        if (Input.GetKeyDown(KeyCode.Keypad3))
            direction = new Vector3(1, 0, -1);

        if(direction.magnitude>0)

        {
            food.tick();
            if (food.isNearlyOver) print("You are getting Hungry");
            if (food.isOver) print("You faint from hunger");
            if (food.overUpperLimit) print("You feel bloated, movement slowed");
          
            Vector3 newPosition = transform.position + direction;
  
            if (theManager.CanMoveTo(this,newPosition))
            {
                transform.position += direction;

                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }

    private void processHit(CharacterControl characterControl, Creature creature)
    {
        throw new NotImplementedException();
    }
}
