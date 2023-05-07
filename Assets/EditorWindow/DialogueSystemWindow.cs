using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DialogueSystemWindow : EditorWindow
{
    
    [MenuItem("Window/Dialogue Editor")]

    static void openWindow()
    {
        DialogueSystemWindow window = (DialogueSystemWindow)GetWindow(typeof(DialogueSystemWindow));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

}
