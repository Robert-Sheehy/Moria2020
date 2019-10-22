using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TestUIText is placed on camera

public class TestUIText : MonoBehaviour
{
    UnityEngine.Object UITextClone;
    UITextControl theTextBubble;
    // Start is called before the first frame update

    float fixedRotation = 5;
    private int MaxNUmberOfTries = 5;
    int actualPx = 0;
    int actualPy = 0;
    


    void Start() 
    {
        //Load Prefab
        UITextClone = Resources.Load("UIText");
        //Create UITextControl object
        theTextBubble = FindObjectOfType<UITextControl>();
    }

    //Coroutine to insure object exists before it is accessed
    private IEnumerator coroutine;
   IEnumerator delayedAccess(UITextControl theText, string Message)
    {
        for (int i = 0; i<MaxNUmberOfTries;i++)
        {
            if (i>0)
            {
                theText.setText(Message);
                i = MaxNUmberOfTries;
            }

            yield return null;
        }
    }


    
    void Update()
    {

        //Creating TMP objects
        UITextControl TextGO;
        UITextControl TextGO1;
        UITextControl TextGO2;
        UITextControl TextGO3;
        UITextControl TextGO4;
        UITextControl TextGO5;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Defining the characteristics of TMP objects
            TextGO = TransformTextGo("Variable 1", new Vector3(0.1f, 0.1f,1.0f));
            TextGO1 = TransformTextGo("Variable 2", new Vector3(0.1f, 0.2f, 1.0f));
            TextGO2 = TransformTextGo("<b>Variable in Bold</b>", new Vector3(0.1f, 0.3f, 1.0f));    
            TextGO3 = TransformTextGo("<color=red>Variable in Red</color>", new Vector3(0.1f, 0.4f, 1.0f));
            TextGO4 = TransformTextGo("<color=red><b>Variable in Bold + Red</b></color>", new Vector3(0.1f, 0.5f, 1.0f));
            TextGO5 = TransformTextGo("<i>Variable <color=blue> in</color> italics + specified blue</i>", new Vector3(0.1f, 0.6f, 1.0f));

        }


 
        //This method returns the mouse position in pixels
        if (Input.GetButtonDown("Fire1"))
        {
            
            Vector3 mousePos = Input.mousePosition;
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
        }

    }//End update


    //Instantiate UITextClone object + position it
    private UITextControl TransformTextGo(string message, Vector3 relPosition)
    { 
       
            GameObject TextGo =(GameObject) Instantiate(UITextClone);
          
            UITextControl text = TextGo.GetComponent<UITextControl>();
            coroutine = delayedAccess(text, message);
            StartCoroutine(coroutine);

            text.positionTextAt(new Vector2(relPosition.x, relPosition.y), relPosition.z);

            return text;
        
    }

  
}
