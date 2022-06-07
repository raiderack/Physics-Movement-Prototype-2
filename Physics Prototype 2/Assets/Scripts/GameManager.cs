using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance { get; private set; }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    public string skinSelected;
    public void SelectedSkin(string skin) {
        skinSelected = skin;
    }

    [System.Serializable]
    class SaveData 
    {
        public int buttonNumber;
    }
    public int buttonNumberPressed;
    
    public void SaveSkinSelection() {
        SaveData data = new SaveData();
        data.buttonNumber = buttonNumberPressed;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        print(data.buttonNumber);
    }

    private void LoadHighScore() {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            buttonNumberPressed = data.buttonNumber;
        }

    }
    
}
