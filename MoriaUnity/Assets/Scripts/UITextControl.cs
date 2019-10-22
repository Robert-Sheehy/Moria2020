using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

//This is attatched to EMPTY OBJECT called UITEXT
//Text mesh pro is parented to UITEXT
//TestUIText is attatched to the text mesh pro object in scene

//x-1 y-0.5 z1
//Use localpositions to define where UI elements go
public class UITextControl : MonoBehaviour
{
    TMP_Text theTextObject;
   // private TextMesh health = new TextMesh();
    GameObject uiText;
    //int formatIncrement = 5;

    void Start()
    {
        theTextObject = GetComponentInChildren<TMP_Text>();

        //Set position of UI
       // theTextObject.transform.localPosition = new Vector3(-11,6);
    } 

  
    

    //NOT WORKING
    public void changeTextSize() { 
        //GetComponent<TextMesh>().fontSize = theTextObject.fontSize + formatIncrement;
    }

    public void transformUI() {
        transform.parent = Camera.main.transform;
      
    }//End transformUI


    internal void setText(string v)
    {
        theTextObject.text = v;
    }//End setText

    void Update()
    {
        //transform.rotation = Quaternion.LookRotation(-(Camera.main.transform.position - transform.position).normalized);
     
    }


    public int calculatePosX(float actualPx)
    {


        return (int)((Screen.width - 1) * actualPx);
    }
    public int calculatePosY(float actualPy)
    {
        return (int)((Screen.height - 1) * actualPy);
    }

    public void positionTextAt(Vector2 relative, float dist)
    {
        Vector2 screenPixelPosition = new Vector2(calculatePosX(relative.x), calculatePosY(relative.y));

        transform.position = Camera.main.ScreenPointToRay(screenPixelPosition).GetPoint(dist);


    }
}
