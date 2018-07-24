using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public PlayerStats player;

    public float fadeOutTime;

    public Text text;

    public GameObject gameCanvas, shopCanvas;

    Color textColor = new Color(1f, 0f, 0f);

    bool startFade;

    private void Start()
    {
        player = FindObjectOfType<PlayerStats>();
        startFade = false;
    }

    public void Buy(int price)
    {
        if (player.score >= price)
        {
            player.score -= price;
        }
        else
        {
            text.color = textColor;
            startFade = true;
        }
    }

    public void ExitShop()
    {
        shopCanvas.SetActive(false);
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
