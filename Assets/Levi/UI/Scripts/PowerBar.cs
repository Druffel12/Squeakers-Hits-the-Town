using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public Slider powerBar;

	void Update ()
    {
        if (powerBar.gameObject.activeInHierarchy == true)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (powerBar.value > 0)
                {
                    powerBar.value -= Time.deltaTime;
                }
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (powerBar.value < powerBar.maxValue)
                {
                    powerBar.value += Time.deltaTime;
                }
            }

        }

	}
}
