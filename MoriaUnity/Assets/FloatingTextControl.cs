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
      
    }

    internal void setMessage(string v)
    {
        bubbleText.text = v;
    }

    internal void copyParentName()
    {
        bubbleText.text = name;
    }

    internal void setParent(Transform transformOfParent)
    {
        transform.parent = transformOfParent;
    }

    internal void setColor()
    {
        Color textColor = new Color(1.5f, 0f, 1.5f);
        bubbleText.color = textColor;
    }

    internal void increaseSize()
    {
        bubbleText.fontSize += 1;
    }

    internal void decreaseSize()
    {
        bubbleText.fontSize -= 1;
    }
}
