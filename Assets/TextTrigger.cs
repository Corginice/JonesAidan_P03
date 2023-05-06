using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public CharText[] texts;
    public Char[] characters;
}
[System.Serializable]
public class CharText
{
    public int charId;
    public string charText;

}
[System.Serializable]
public class Char
{
    public string name;
    public Sprite Image;
}