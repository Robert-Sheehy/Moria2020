using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int[,] theMap;
    void Start()
    {
        theMap = new int[100, 100];

        theMap[5, 5] = 100;
    }

    void Update()
    {
        
    }

    internal bool canMoveTo(Vector3 newPosition)
    {
        return theMap[(int)newPosition.x, (int)newPosition.z] < 10;
    }
}
