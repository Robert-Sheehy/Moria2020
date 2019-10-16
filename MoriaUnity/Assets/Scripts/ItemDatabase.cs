using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<accessItem> items = new List<accessItem>();

    void BuildDatabase()
    {
        items = new List<accessItem>(
                );
    }
}
