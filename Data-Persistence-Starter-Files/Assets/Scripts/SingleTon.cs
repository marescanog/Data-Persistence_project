using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SingleTon : MonoBehaviour
{

    public static SingleTon s_Instance;
    public string PlayerName;
    public int highestScore = 0;
    public bool setLabel = false;
    public bool hasSaveFile = false;

    private void Awake()
    {
        if (s_Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        s_Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadNameAndScore();
    }

    public void updateHighestScore(int score) {
        if (score > highestScore) {
            highestScore = score;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string savedPlayerName = " ";
        public int savedHighestScore = 0;
    }

    public void SaveNameAndScore()
    {
        SaveData data = new SaveData();
        data.savedPlayerName = PlayerName;
        data.savedHighestScore = highestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadNameAndScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName = data.savedPlayerName;
            highestScore = data.savedHighestScore;
            hasSaveFile = true;
            setLabel = true;
        }
    }

}
