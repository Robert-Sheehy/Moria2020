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
        myBubble = FindObjectOfType<FloatingTextControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  Instantiate(FloatingTextClonable);

        if (Input.GetKeyDown(KeyCode.A)) myBubble.setMessage("Moria2020");
        if (Input.GetKeyDown(KeyCode.S)) myBubble.copyParentName();
        if (Input.GetKeyDown(KeyCode.B)) myBubble.setParent(transform);
        if (Input.GetKeyDown(KeyCode.C)) myBubble.setColor();
        if (Input.GetKeyDown(KeyCode.UpArrow)) myBubble.increaseSize();
        if (Input.GetKeyDown(KeyCode.DownArrow)) myBubble.decreaseSize();
    }
}