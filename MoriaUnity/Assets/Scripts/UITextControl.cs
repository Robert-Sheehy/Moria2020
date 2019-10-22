using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;




public class UITextControl : MonoBehaviour
{
    //Creating TMP variables
    TMP_Text theTextObject;
    GameObject uiText;

   
    void Start()
    {
        //Create object of TMP Text
        theTextObject = GetComponentInChildren<TMP_Text>();

    } 

  
    

    public void changeTextSize() { 
        //Deleted for now
    }

    public void transformUI() {
        transform.parent = Camera.main.transform;
      
    }//End transformUI

    //Change UI text
    internal void setText(string v)
    {
        theTextObject.text = v;
    }//End setText

    //Returns the xPosition on screen
    public int calculatePosX(float actualPx)
    {


        return (int)((Screen.width - 1) * actualPx);
    }

    //Returns the yPosition on screen
    public int calculatePosY(float actualPy)
    {
        return (int)((Screen.height - 1) * actualPy);
    }

    //Placing text objects at screen position
    public void positionTextAt(Vector2 relative, float dist)
    {
        Vector2 screenPixelPosition = new Vector2(calculatePosX(relative.x), calculatePosY(relative.y));

        transform.position = Camera.main.ScreenPointToRay(screenPixelPosition).GetPoint(dist);


    }
}
