using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    bool aiming = false;
    public Slider powerSlider;
    public Text tutorialText;

	public void Activate()
    {
        aiming = false;
        powerSlider.gameObject.SetActive(true);
        //tutorialText.gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        aiming = true;

        powerSlider.gameObject.SetActive(false);
        //tutorialText.gameObject.SetActive(false);
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (aiming == true)
            {
                Activate();
            }
            else if (aiming == false)
            {
                Deactivate();
            }

        }
	}
}
