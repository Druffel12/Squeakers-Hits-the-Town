using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public SceneFader sceneFader;

    public void LoadLevel()
    {
        sceneFader.FadeTo("Zach's Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
