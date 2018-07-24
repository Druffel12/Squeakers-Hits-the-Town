using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    bool aiming = false;
    public Slider powerSlider;
    public Text tutorialText;
    public Texture2D reticle;
    CursorMode cursorMode = CursorMode.Auto;
    Vector2 hotSpot = Vector2.zero;

	public void Activate()
    {
        aiming = false;
        powerSlider.gameObject.SetActive(true);
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void Deactivate()
    {
        aiming = true;
        powerSlider.gameObject.SetActive(false);
        Cursor.SetCursor(reticle, hotSpot, cursorMode);
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
