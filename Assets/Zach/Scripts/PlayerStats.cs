using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int score;
    
	// Use this for initialization
	void Start ()
    {
        score = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Developer cheat while we don't have a way to earn score
		if (Input.GetKeyDown(KeyCode.Tab))
        {
            score += 50;
        }
	}
}
