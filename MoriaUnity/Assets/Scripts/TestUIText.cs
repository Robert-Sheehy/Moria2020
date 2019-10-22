using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UITextCibtrol is attatched to EMPTY OBJECT called UITEXT
//Text mesh pro is parented to UITEXT
//TestUIText is attatched to the text mesh pro object in scene

public class TestUIText : MonoBehaviour
{
    UnityEngine.Object UITextClone;
    UITextControl theTextBubble;
    // Start is called before the first frame update

    float fixedRotation = 5;
    private int MaxNUmberOfTries = 5;
    int actualPx = 0;
    int actualPy = 0;
    //Vector2 r = Camera.main.ScreenPointToRay();
    //int x = Screen.width / 2;
    //int y = Screen.width / 2;


    void Start()
    {

        UITextClone = Resources.Load("UIText");
        theTextBubble = FindObjectOfType<UITextControl>();
    }

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


    //SCREEN POSITION
    //(rx,ry) = (actualPx/Screen.width , actualPy/Screen.height)
    //Point (a,b) = ((a*Screen.width),(b*ScreenHeight))
    //r = camera.main.ScreenPointToRay( )

    // Ray ray = Camera.main.ScreenPointToRay(new Vector3(200, 200, 0));        

    // Update is called once per frame
    void Update()
    {

        UITextControl TextGO;
        if (Input.GetKeyDown(KeyCode.Space))
        {//Create this method*********************************************
            TextGO = TransformTextGo("sfjkdygsdeufg", new Vector3(0.5f, 0.1f,1.0f));
        }


 

        if (Input.GetButtonDown("Fire1"))
        {
            //  r = Camera.main.ScreenPointToRay();
            // position = r.distance();
            //Debug.Log("You clicked");
            Vector3 mousePos = Input.mousePosition;
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
        }

    }//End update


    private UITextControl TransformTextGo(string message, Vector3 relPosition)
    { 
            //Vector3 pos = default;
            //Quaternion rot = defaullt;
            //transform.SetPositionAndRotation(pos, rot);

            GameObject TextGo =(GameObject) Instantiate(UITextClone);
            
            //Transform TextGO = Instantiate(textPrefab);
            UITextControl text = TextGo.GetComponent<UITextControl>();
            coroutine = delayedAccess(text, message);
            StartCoroutine(coroutine);

            text.positionTextAt(new Vector2(relPosition.x, relPosition.y), relPosition.z);

            return text;
        
    }

}
