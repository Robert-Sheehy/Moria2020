using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Transform WallPrefab;
    ItemsControl items;
    const int WORLD_WIDTH = 100, WORLD_DEPTH = 100;
    int[,] theMap;


    // Start is called before the first frame update
    void Start()
    {
        int currentLevel = 10;
        theMap = new int[WORLD_WIDTH, WORLD_DEPTH];
        items = FindObjectOfType<ItemsControl>();
        theMap[5, 5] = 100;
        Instantiate(WallPrefab, new Vector3(5, 0, 5), Quaternion.identity);
        for (int i = 0; i < 10; i++)
        generateRandomItem(currentLevel);

    }

    private void generateRandomItem(int currentLevel)
    {
        accessItem newItem = items.getRandomItem(currentLevel);

        Vector2Int newItemPosition = randomPosition();

        newItem.transform.position = new Vector3(newItemPosition.x, 0, newItemPosition.y);
    }

    internal Vector2Int randomPosition()
    {
        return new Vector2Int(UnityEngine.Random.Range(0, WORLD_WIDTH), UnityEngine.Random.Range(0, WORLD_DEPTH));

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
