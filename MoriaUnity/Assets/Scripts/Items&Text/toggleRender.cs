using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleRender : MonoBehaviour
{
    public void toggleVisibility()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();

        if(rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }
    }
}
