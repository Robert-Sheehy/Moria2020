using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FloatingTextControl : MonoBehaviour
{
    TMP_Text bubbleText;
    // Start is called before the first frame update
    void Start()
    {
        bubbleText = GetComponentInChildren<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotates text to look toward the main camera
        transform.rotation = Quaternion.LookRotation(-(Camera.main.transform.position - transform.position).normalized, Vector3.up);
    }

    internal void setMessage(string v)
    {
        //Simple method to change the text on display
        bubbleText.text = v;
    }

    internal void setParent(Transform transformOfParent)
    {
        //Attaches the text to its parent and moves it to the parent location
        transform.parent = transformOfParent;
        transform.localPosition = Vector3.zero;
    }

    internal void setColor(Color textColor)
    {
        //Method to change the color of the text through means of a Color object
        bubbleText.color = textColor;
    }

    internal void increaseSize()
    {
        //Increases text font size by 2, used in displaying description text
        bubbleText.fontSize += 2;
    }

    internal void decreaseSize()
    {
        //Decreases text font size by 2, used in displaying description text
        bubbleText.fontSize -= 2;
    }

    internal void transparencyOn()
    {
        //Turns the text semi transparent
        Color transparency = new Color(1f, 1f, 1f, 0.2f);
        bubbleText.color = transparency;
    }

    internal void transparencyOff()
    {
        //Returns to text to full opacity
        Color transparency = new Color(1f, 1f, 1f, 1f);
        bubbleText.color = transparency;
    }
}
