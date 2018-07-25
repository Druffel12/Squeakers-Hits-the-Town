using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SlingshotManager sling;
    public Text instructionalText;
    public GameObject gameCanvas, shopCanvas;
    public PlayerStats player;

	// Use this for initialization
	void Start ()
    {
        sling = FindObjectOfType<SlingshotManager>();
        player = FindObjectOfType<PlayerStats>();
        instructionalText.text = "Press Space to begin aiming";
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (sling.aiming == true)
        {
            instructionalText.text = "Use the mouse to aim, and press space again to lock position";
        }

        if (sling.firePositionSet == true)
        {
            instructionalText.text = "Use the up/down arrows to increase power";
        }

        if (sling.firePowerSet == true)
        {
            instructionalText.text = "Press the left mouse button to fire";
        }

        if (sling.shotFired == true)
        {
            sling.aiming = false;
            sling.firePositionSet = false;
            sling.firePowerSet = false;
            instructionalText.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.score += 100;
        }
	}
}
