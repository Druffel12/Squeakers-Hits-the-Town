﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public Canvas gameCanvas;
    public Canvas pauseCanvas;
    public Canvas shopCanvas;
    public AudioSource elevatorMusic, gameMusic;

    public void PauseGame()
    {
        gameMusic.Pause();
        elevatorMusic.Play();
        gameCanvas.gameObject.SetActive(false);
        pauseCanvas.gameObject.SetActive(true);
        //Time.timeScale = 0;
    }

    public void OpenShop()
    {
        elevatorMusic.Stop();
        gameCanvas.gameObject.SetActive(false);
        shopCanvas.gameObject.SetActive(true);
    }
	
    public void ResumeGame()
    {
        gameMusic.UnPause();
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
                //Cursor.lockState = CursorLockMode.Locked;
                //Cursor.visible = false;
                ResumeGame();
            }
            else if (Time.timeScale == 1)
            {
                //Cursor.lockState = CursorLockMode.None;
                //Cursor.visible = true;
                PauseGame();
            }
        }
	}
}
