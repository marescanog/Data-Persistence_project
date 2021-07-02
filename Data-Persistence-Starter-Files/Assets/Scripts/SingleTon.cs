using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTon : MonoBehaviour
{

    public static SingleTon s_Instance;
    public string PlayerName;
    public int highestScore = 0;
    public bool setLabel = false;

    private void Awake()
    {
        if (s_Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        s_Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void updateHighestScore(int score) {
        if (score > highestScore) {
            highestScore = score;
        }
    }
}
