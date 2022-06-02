using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneFlowManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
