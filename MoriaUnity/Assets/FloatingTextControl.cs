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
        bubbleText.text = v;
    }

    internal void copyParentName(String parentName)
    {
        bubbleText.text = parentName;
    }

    internal void setParent(Transform transformOfParent)
    {
        //Attaches the text to its parent and moves it to the parent location
        transform.parent = transformOfParent;
        transform.localPosition = Vector3.zero;
    }

    internal void setColor()
    {
        Color textColor = new Color(1.5f, 0f, 1.5f);
        bubbleText.color = textColor;
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
