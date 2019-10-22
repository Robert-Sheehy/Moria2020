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
        Instantiate(FloatingTextClonable);
        myBubble = FindObjectOfType<FloatingTextControl>();
       
    }

    // Update is called once per frame
    void Update()
    {
        myBubble.copyParentName(name);
        myBubble.setParent(transform);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(FloatingTextClonable);
            myBubble = FindObjectOfType<FloatingTextControl>();
        }

        if (Input.GetKeyDown(KeyCode.LeftControl)) myBubble.transparencyOn();

        if (Input.GetKeyUp(KeyCode.LeftControl)) myBubble.transparencyOff();

        if (Input.GetKey(KeyCode.A)) myBubble.setMessage("1d4 Dmg" + "\n(0,0)");

        if(Input.GetKeyDown(KeyCode.A)) myBubble.decreaseSize();

        if (Input.GetKeyUp(KeyCode.A))
        {
            myBubble.copyParentName(name);
            myBubble.increaseSize();
        }

        if (Input.GetKeyDown(KeyCode.S)) myBubble.copyParentName(name);
        if (Input.GetKeyDown(KeyCode.B)) myBubble.setParent(transform);
        if (Input.GetKeyDown(KeyCode.C)) myBubble.setColor();
        if (Input.GetKeyDown(KeyCode.PageUp)) myBubble.increaseSize();
        if (Input.GetKeyDown(KeyCode.PageDown)) myBubble.decreaseSize();
    }
}