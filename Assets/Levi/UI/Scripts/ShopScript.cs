using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public PlayerStats player;

    public float fadeOutTime;

    public Text text;

    public GameObject gameCanvas, shopCanvas, angelHat, armyHat, partyHat;

    Color textColor = new Color(1f, 0f, 0f);

    bool startFade;

    private void Start()
    {
        player = FindObjectOfType<PlayerStats>();
        startFade = false;
    }

    public void BuyOne(int price)
    {
        if (player.score >= price)
        {
            player.score -= price;
            angelHat.SetActive(true);
            armyHat.SetActive(false);
            partyHat.SetActive(false);
        }
        else
        {
            text.color = textColor;
            startFade = true;
        }
    }
    public void BuyTwo(int price)
    {
        if (player.score >= price)
        {
            player.score -= price;
            armyHat.SetActive(true);
            angelHat.SetActive(false);
            partyHat.SetActive(false);
        }
        else
        {
            text.color = textColor;
            startFade = true;
        }
    }
    public void BuyThree(int price)
    {
        if (player.score >= price)
        {
            player.score -= price;
            partyHat.SetActive(true);
            angelHat.SetActive(false);
            armyHat.SetActive(false);
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
