using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public PlayerStats player;

    public PauseScript pause;

    public float fadeOutTime;

    public Text text;

    public GameObject gameCanvas, shopCanvas, angelHat, armyHat, partyHat, kobeyDeer, squeakers;

    Color textColor = new Color(1f, 0f, 0f);

    bool startFade;

    public bool ratActive, deerActive;

    public AudioSource purchaseSound, errorSound, suspenseSound, gameMusic, shopMusic;

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
            kobeyDeer.SetActive(false);
            squeakers.SetActive(true);
            ratActive = true;
            deerActive = false;

            purchaseSound.Play();
        }
        else
        {
            text.color = textColor;
            startFade = true;

            errorSound.Play();
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
            kobeyDeer.SetActive(false);
            squeakers.SetActive(true);
            ratActive = true;
            deerActive = false;

            purchaseSound.Play();
        }
        else
        {
            text.color = textColor;
            startFade = true;

            errorSound.Play();
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
            kobeyDeer.SetActive(false);
            squeakers.SetActive(true);
            ratActive = true;
            deerActive = false;

            purchaseSound.Play();
        }
        else
        {
            text.color = textColor;
            startFade = true;

            errorSound.Play();
        }
    }
    public void BuyFour(int price)
    {
        if (player.score >= price)
        {
            player.score -= price;
            partyHat.SetActive(false);
            angelHat.SetActive(false);
            armyHat.SetActive(false);
            kobeyDeer.SetActive(true);
            squeakers.SetActive(false);
            ratActive = false;
            deerActive = true;

            suspenseSound.Play();
            shopMusic.Stop();
            gameMusic.Stop();
        }
        else
        {
            text.color = textColor;
            startFade = true;

            errorSound.Play();
        }
    }

    public void ExitShop()
    {
        pause.elevatorMusic.Play();
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
