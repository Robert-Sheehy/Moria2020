using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadModelTest : MonoBehaviour
{
    GameObject handleGO;
    GameObject textGO;
    ItemInfo info;
    // Start is called before the first frame update
    void Start()
    {
        //string itemName = info.getName();
        info = handleGO.GetComponent<ItemInfo>();
        GameObject TextBubble = Resources.Load("FloatingText") as GameObject;
        GameObject handle = Resources.Load("Dagger") as GameObject;

        handleGO = Instantiate(handle);
        //handleGO.name = ("Dagger");
        textGO = Instantiate(TextBubble);
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.A)) handleGO.name = info.getName();
    }
}