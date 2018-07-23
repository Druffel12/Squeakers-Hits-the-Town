using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    PlayerStats player;
    SlingshotManager slingshot;
    //public GameObject upgradeUI;
    public Toggle rocketBooster;

	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<PlayerStats>();
        slingshot = FindObjectOfType<SlingshotManager>();
        //upgradeUI.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Escape))
        //{
        //    upgradeUI.SetActive(true);
        //    Time.timeScale = 0;
        //}
    }
}
