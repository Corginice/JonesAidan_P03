using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;



public class DialogueSystemWindow : EditorWindow
{
    TextManager settings;


    Texture2D headerSectionTexture;
    Texture2D TextSectionTexture;
    Texture2D NameSectionTexture;
    Texture2D AvatarSectionTexture;
    Texture2D BoxSectionTexture;

    Color headerSectionColor = new Color(13f / 255f, 32f / 255f, 70f/ 255f, 1f);

    Rect headerSection;
    Rect textSection;
    Rect nameSection;
    Rect avatarSection;
    Rect boxSection;

    public Image charImage;
    public Text charName;
    public Text messageText;
    public RectTransform backgroundBox;


    [MenuItem("Window/Dialogue Editor")]

    static void openWindow()
    {
        DialogueSystemWindow window = (DialogueSystemWindow)GetWindow(typeof(DialogueSystemWindow));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

   void OnEnable()
    {
        InitTextures();
        settings = GameObject.FindGameObjectWithTag("Tags").GetComponent<TextManager>();

        settings.DisplayText();
    }
     
    void InitTextures()
    {
        headerSectionTexture = new Texture2D(1, 1);
        headerSectionTexture.SetPixel(0, 0, headerSectionColor);
        headerSectionTexture.Apply();
    }

    void OnGUI()
    {

        DrawLayout();
        DrawHeader();
        drawBoxSettings();
        drawText();
        drawAvatar();
        drawName();
       
    }

    void DrawLayout()
    {
        headerSection.x = 0;
        headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 50;

        GUI.DrawTexture(headerSection, headerSectionTexture);
    }

    void DrawHeader()
    {
        GUILayout.Label("Dialogue System Editor");
    }

    void drawBoxSettings()
    {
        if (GUILayout.Button("Box", GUILayout.Height(40)))
        {
            GeneralSettings.OpenWindow(GeneralSettings.SettingsType.BOX);
        }
    }

    void drawText()
    {
        if (GUILayout.Button("Text", GUILayout.Height(30)))
        {
            GeneralSettings.OpenWindow(GeneralSettings.SettingsType.TEXT);
        }
    }

    void drawAvatar()
    {

        if (GUILayout.Button("Avatar", GUILayout.Height(30)))
        {
            GeneralSettings.OpenWindow(GeneralSettings.SettingsType.IMAGE);
        }
    }

    void drawName()
    {
        if (GUILayout.Button("Name", GUILayout.Height(30)))
        {
            GeneralSettings.OpenWindow(GeneralSettings.SettingsType.NAME);
        }
    }

    public class GeneralSettings : EditorWindow
    {
        public enum SettingsType
        {
            TEXT,
            BOX,
            IMAGE,
            NAME
        }

        static SettingsType dataSettings;
        static GeneralSettings window;

        public static void OpenWindow(SettingsType setting)
        {
            dataSettings = setting;
            window = (GeneralSettings)GetWindow(typeof(GeneralSettings));
            window.minSize = new Vector2(250, 250);
            window.Show();
        }
    }
    
}
