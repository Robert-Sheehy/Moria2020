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
        transform.rotation = Quaternion.LookRotation(Vector3.down);
    }

    internal void setMessage(string v)
    {
        bubbleText.text = v;
    }

    internal void copyParentName(String parentName)
    {
        bubbleText.text = parentName;
    }

    internal void setParent(Transform transformOfParent)
    {
        transform.parent = transformOfParent;

        //sets position of the text
        transform.localPosition = new Vector3(0.0f,0.0f,-2.0f);
    }

    internal void setColor()
    {
        Color textColor = new Color(1f, 1f, 1f);
        bubbleText.color = textColor;

        //set font size
        bubbleText.fontSize = 8;
    }

    internal void increaseSize()
    {
        bubbleText.fontSize += 2;
    }

    internal void decreaseSize()
    {
        bubbleText.fontSize -= 2;
    }

    internal void transparencyOn()
    {
        Color transparency = new Color(1f, 1f, 1f, 0.2f);
        bubbleText.color = transparency;
    }

    internal void transparencyOff()
    {
        Color transparency = new Color(1f, 1f, 1f, 1f);
        bubbleText.color = transparency;
    }
}
