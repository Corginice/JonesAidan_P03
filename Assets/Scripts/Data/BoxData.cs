using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Types;

[CreateAssetMenuAttribute(fileName = "NewBoxData", menuName = "TextData/Box")]
public class BoxData : TextData
{
    public BoxType boxSize;
}
