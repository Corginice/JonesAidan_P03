using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextManager : MonoBehaviour
{
    public Image charImage;
    public Text charName;
    public Text messageText;
    public RectTransform backgroundBox;

     CharText[] texts;
     Char[] characters;
    int activeText = 0;
    public static bool isActive = false;


    public void OpenDialogue(CharText[] text, Char[] character)
    {
        texts = text;
        characters = character;
        activeText = 0;
        isActive = true;
        Debug.Log("StartedInteraction! Loaded Text:" + text.Length);
        DisplayText();
    }

    public void DisplayText()
    {
        CharText textToDisplay = texts[activeText];
        messageText.text = textToDisplay.charText;

        Char charToDisplay = characters[textToDisplay.charId-1];
        charName.text = charToDisplay.name;
        charImage.sprite = charToDisplay.Image;
    }

    public void updateText()
    {
        activeText++;
        if(activeText < texts.Length)
        {
            DisplayText();
        }
        else
        {
            Debug.Log("Conversation Over!");
            isActive = false;
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isActive == true)
        {
            updateText();
        }
    }
}
