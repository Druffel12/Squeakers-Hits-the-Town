using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public float score;

    public float fadeOutTime;

    public Text text;

    Color textColor = new Color(1f, 0f, 0f);

    bool startFade;

    private void Start()
    {
        startFade = false;
    }

    public void Buy(int price)
    {
        if (score >= price)
        {
            score -= price;
        }
        else
        {
            text.color = textColor;
            startFade = true;
        }
    }

    private void Update()
    {
        if(startFade == true)
        {
            text.color = Color.Lerp(text.color, Color.clear, fadeOutTime * Time.deltaTime);
        }
        if(text.color == Color.clear)
        {
            startFade = false;
        }
    }

}
