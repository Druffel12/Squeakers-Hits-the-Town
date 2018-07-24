using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public void GoToMouse()
    {
        Vector3 mousePosition = Input.mousePosition;

        Vector3 imagePosition = gameObject.GetComponent<RectTransform>().position;
        imagePosition = Camera.main.ScreenToWorldPoint(mousePosition);
    }

	void Update ()
    {
        GoToMouse();
	}
}
