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
    [SerializeField] Text label;
    [SerializeField] InputField inputField;

    private void Start()
    {
        if (SingleTon.s_Instance != null && SingleTon.s_Instance.hasSaveFile)
        {
            label.text = "Best Score : "+ SingleTon.s_Instance.PlayerName + " : " + SingleTon.s_Instance.highestScore;
            inputField.text = SingleTon.s_Instance.PlayerName;
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
        if (SingleTon.s_Instance != null)
        {
            SingleTon.s_Instance.PlayerName = inputField.text;

        }
    }

    public void Exit()
    {
        SingleTon.s_Instance.SaveNameAndScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif

    }


}
