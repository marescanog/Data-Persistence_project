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
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
    }

}
