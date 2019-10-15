using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Buttons : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject LevelSelectPanel;
    public GameObject SaveGamePanel;
    public GameObject OptionsPanel;
    public GameObject CreditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
        SaveGamePanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        MenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
        SaveGamePanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
        SaveGamePanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void ShowSaveGamePanel()
    {
        MenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        SaveGamePanel.SetActive(true);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void ShowOptionsPanel()
    {
        MenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        SaveGamePanel.SetActive(false);
        OptionsPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }

    public void ShowCreditsPanel()
    {
        MenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        SaveGamePanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }
}
