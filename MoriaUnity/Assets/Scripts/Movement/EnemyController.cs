using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Movement thePlayer;
    Vector3 PlayerPosition = new Vector3(0, 0, 0);
    void Start(){
        thePlayer = FindObjectOfType<Movement>();
        Vector3 dir = Vector3.zero;
        
    }

    void Update(){
        print(getDirection());
        if (IshouldMove()) MoveMe(getDirection());
    }

    private void MoveMe(Vector3 v)
    {
        transform.position += v;
        transform.rotation = Quaternion.LookRotation(v);
    }

    private bool IshouldMove()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            return Input.GetKeyDown(KeyCode.Keypad8);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            return Input.GetKeyDown(KeyCode.Keypad9);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            return Input.GetKeyDown(KeyCode.Keypad7);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            return Input.GetKeyDown(KeyCode.Keypad4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            return Input.GetKeyDown(KeyCode.Keypad6);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            return Input.GetKeyDown(KeyCode.Keypad1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            return Input.GetKeyDown(KeyCode.Keypad2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            return Input.GetKeyDown(KeyCode.Keypad3);
        }
        return Input.GetKeyDown(KeyCode.Keypad5);
    }

    Vector3 getDirection(){ 
        Vector3 dir = thePlayer.transform.position - transform.position;
        return unitize(dir);
    }

    
    private Vector3 unitize(Vector3 v){
        return new Vector3(unitize(v.x), unitize(v.y), unitize(v.z));
    }


    private float unitize(float x){
        float buff = 0.1f;
        if (x < -buff) return -0.5f;
        if (x > buff) return 0.5f;
        return 0.0f;
    }
}
