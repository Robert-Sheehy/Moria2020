using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Transform WallPrefab;
    int[,] theMap;
    // Start is called before the first frame update
    void Start()
    {
        theMap = new int[100, 100];

        theMap[5, 5] = 100;
        Instantiate(WallPrefab, new Vector3(5, 0, 5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal bool CanMoveTo(Vector3 newPosition)
    {
        return theMap[(int)newPosition.x, (int)newPosition.z] < 10;
    }
}
