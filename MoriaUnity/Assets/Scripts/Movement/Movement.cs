using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    GameManagerScript theManager;
    void Start()
    {
        theManager = FindObjectOfType<GameManagerScript>();
    }

    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            direction = new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            direction = new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            direction = new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            direction = new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            direction = new Vector3(-1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            direction = new Vector3(1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            direction = new Vector3(-1, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            direction = new Vector3(1, 0, -1);
        }

        if (direction.magnitude > 0)
        {
            Vector3 newPosition = transform.position + direction;
            if (theManager.canMoveTo(newPosition))
            {
                transform.position += direction;
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}
