using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SkinSelector : MonoBehaviour
{
    public int skinSelected;
    public void ClickedOne() {
        
        GameManager.instance.buttonNumberPressed = 1;
        GameManager.instance.SaveSkinSelection();
        skinSelected = 1;
        GameManager.instance.SelectedSkin("blue1");
    }

    public void ClickedTwo() {
        
        GameManager.instance.buttonNumberPressed = 2;
        GameManager.instance.SaveSkinSelection();
        skinSelected = 2;
        GameManager.instance.SelectedSkin("green1");
    }
    
    public void EnterMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    
}
