using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFloatingText : MonoBehaviour
{
    public Transform FloatingTextClonable;

    FloatingTextControl myBubble;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiates the clonable text prefab and finds the text control Object
        myBubble = FindObjectOfType<FloatingTextControl>();
    }

    // Update is called once per frame
    void Update()
    {
        //Calls methods to copy and mirror the name and location of the item the text is attached to
        myBubble.setMessage(name);
        myBubble.setParent(transform);

        //Makes text transparent when a key is held
        if (Input.GetKeyDown(KeyCode.LeftControl)) myBubble.transparencyOn();

        if (Input.GetKeyUp(KeyCode.LeftControl)) myBubble.transparencyOff();

        //Changes text when a key is held
        if (Input.GetKey(KeyCode.A)) myBubble.setMessage("1d4 Dmg" + "\n(0,0)");

        if(Input.GetKeyDown(KeyCode.A)) myBubble.decreaseSize();

        if (Input.GetKeyUp(KeyCode.A))
        {
            myBubble.setMessage(name);
            myBubble.increaseSize();
        }

        //Test functions, to be removed before final product
        if (Input.GetKeyDown(KeyCode.S)) myBubble.setMessage(name);
        if (Input.GetKeyDown(KeyCode.B)) myBubble.setParent(transform);
        if (Input.GetKeyDown(KeyCode.PageUp)) myBubble.increaseSize();
        if (Input.GetKeyDown(KeyCode.PageDown)) myBubble.decreaseSize();
    }
}