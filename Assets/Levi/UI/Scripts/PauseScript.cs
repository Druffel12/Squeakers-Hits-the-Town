using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public Canvas gameCanvas;
    public Canvas pauseCanvas;
    public Canvas shopCanvas;


    public void PauseGame()
    {
        gameCanvas.gameObject.SetActive(false);
        pauseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
	
    public void ResumeGame()
    {
        gameCanvas.gameObject.SetActive(true);
        pauseCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 0 && shopCanvas.gameObject.activeInHierarchy == false)
            {
                ResumeGame();
            }
            else if (Time.timeScale == 1)
            {
                PauseGame();
            }
        }
	}
}
