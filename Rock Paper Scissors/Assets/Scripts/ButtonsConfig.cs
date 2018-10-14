using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsConfig : MonoBehaviour {

    public GameObject RockSprite;
    public GameObject PaperSprite;
    public GameObject ScissorsSprite;
    public Text LeftText;
    public Button RockButton;
    public Button PaperButton;
    public Button ScissorsButton;



    public void rockButtonChoose()
    {
        RockSprite.SetActive(true);
        PaperSprite.SetActive(false);
        ScissorsSprite.SetActive(false);
        LeftText.text = "Rock";
        disableButtons();
        Invoke("fadeSprites", 2);
    }

    public void paperButtonChoose()
    {
        RockSprite.SetActive(false);
        PaperSprite.SetActive(true);
        ScissorsSprite.SetActive(false);
        LeftText.text = "Paper";
        disableButtons();
        Invoke("fadeSprites", 2);
    }

    public void scissorsButtonChoose()
    {
        RockSprite.SetActive(false);
        PaperSprite.SetActive(false);
        ScissorsSprite.SetActive(true);
        LeftText.text = "Scissors";
        disableButtons();
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
}
