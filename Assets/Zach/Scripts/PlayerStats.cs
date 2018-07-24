using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int score;
    public Text scoreText;
    
	// Use this for initialization
	void Start ()
    {
        score = 0;
        scoreText.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score: " + score.ToString();
	}
}
