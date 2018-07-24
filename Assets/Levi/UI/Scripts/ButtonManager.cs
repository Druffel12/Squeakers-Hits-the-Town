using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadLevel(string wool)
    {
        SceneManager.LoadScene(wool);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
