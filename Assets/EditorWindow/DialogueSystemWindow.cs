using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DialogueSystemWindow : EditorWindow
{
    Texture2D headerSectionTexture;
    Texture2D TextSectionTexture;
    Texture2D NameSectionTexture;
    Texture2D AvatarSectionTexture;
    Texture2D BoxSectionTexture;

    Color headerSectionColor = new Color(13f / 255f, 32f / 255f, 44f / 255f, 1f);

    Rect headerSection;
    Rect textSection;
    Rect nameSection;
    Rect avatarSection;
    Rect boxSection;

    [MenuItem("Window/Dialogue Editor")]

    static void openWindow()
    {
        DialogueSystemWindow window = (DialogueSystemWindow)GetWindow(typeof(DialogueSystemWindow));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

   void OnEnable()
    {
        
    }

    void InitTextures()
    {

    }

    void OnGUI()
    {
        
    }

    void DrawLayout()
    {

    }

    void DrawHeader()
    {

    }

    void drawBox()
    {

    }

    void drawText()
    {

    }

    void drawAvatar()
    {

    }

    void drawName()
    {

    }
}
