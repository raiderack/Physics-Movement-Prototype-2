using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class MainMenuManager : MonoBehaviour
{

    public void EnterMultiplayer() {
        SceneManager.LoadScene("SampleScene");
    }

    public void EnterCollection() {
        SceneManager.LoadScene("Collection");
    }

    public void EnterMarket() {
        SceneManager.LoadScene("Market");
    }

    public void EnterOptions() {
        SceneManager.LoadScene("Options");
    }

    public void EnterMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }

    public void Exit() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
