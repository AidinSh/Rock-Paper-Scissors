using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsConfig : MonoBehaviour
{

    public GameObject RockSprite;
    public GameObject PaperSprite;
    public GameObject ScissorsSprite;
    public Text LeftText;
    public Button RockButton;
    public Button PaperButton;
    public Button ScissorsButton;
    public Text winText;
    public string p1;
    public string p2 = "Paper";

    public string winner;


    public void rockButtonChoose()
    {
        p1 = "Rock";
        Invoke("showSprites", 3);
        disableButtons();

    }

    public void paperButtonChoose()
    {
        p1 = "Paper";
        Invoke("showSprites", 3);
        disableButtons();

    }

    public void scissorsButtonChoose()
    {
        p1 = "Scissors";
        Invoke("showSprites", 3);
        disableButtons();

    }


    public void showSprites()
    {
        switch (p1)
        {
            case "Rock":
                RockSprite.SetActive(true);
                PaperSprite.SetActive(false);
                ScissorsSprite.SetActive(false);
                LeftText.text = "Rock"; break;

            case "Paper":
                RockSprite.SetActive(false);
                PaperSprite.SetActive(true);
                ScissorsSprite.SetActive(false);
                LeftText.text = "Paper"; break;

            case "Scissors":
                RockSprite.SetActive(false);
                PaperSprite.SetActive(false);
                ScissorsSprite.SetActive(true);
                LeftText.text = "Scissors"; break;
        }
        Invoke("showWinText", 3);
        Invoke("fadeSprites", 2);
    }

    public void disableButtons()
    {
        RockButton.interactable = false;
        PaperButton.interactable = false;
        ScissorsButton.interactable = false;
    }

    public void fadeSprites()
    {
        RockSprite.SetActive(false);
        PaperSprite.SetActive(false);
        ScissorsSprite.SetActive(false);
        LeftText.text = "";
        RockButton.interactable = true;
        PaperButton.interactable = true;
        ScissorsButton.interactable = true;
    }

    void Update()
    {
        switch (p1)
        {
            case "Rock":
                switch (p2)
                {
                    case "Rock": winner = "tie"; break;
                    case "Paper": winner = "p2"; break;
                    case "Scissors": winner = "p1"; break;
                }
                break;
            case "Paper":
                switch (p2)
                {
                    case "Rock": winner = "p1"; break;
                    case "Paper": winner = "tie"; break;
                    case "Scissors": winner = "p2"; break;
                }
                break;

            case "Scissors":
                switch (p2)
                {
                    case "Rock": winner = "p2"; break;
                    case "Paper": winner = "p1"; break;
                    case "Scissors": winner = "tie"; break;
                }
                break;
        }
        
    }

    public void showWinText()
    {
        switch (winner)
        {
            case "p1": winText.text = "Player 1 won this round !"; break;
            case "p2": winText.text = "Player 2 won this round !"; break;
            case "tie": winText.text = " TIE !"; break;
        }
    }
}
