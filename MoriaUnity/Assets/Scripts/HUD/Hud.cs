using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    TextMeshPro text;

    public GameObject MessagePanel;
    public void OpenMessagePanel(TextMeshPro text)
    {
        MessagePanel.SetActive(true);
    }
    public void CloseMessgaePanel()
    {
        MessagePanel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
