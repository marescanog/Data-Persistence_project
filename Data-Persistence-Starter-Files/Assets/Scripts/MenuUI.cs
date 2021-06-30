using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }

    public void SetName(string playerName)
    {
        MainManager1.Instance.PlayerName = playerName;
    }

    private void Start()
    {
        if(MainManager1.Instance != null)
        {
            //Set Player Name
        }
    }

}
