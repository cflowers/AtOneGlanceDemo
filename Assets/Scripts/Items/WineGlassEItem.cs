using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class WineGlassEItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_WineGlassE");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/wineglassE");

    }
}
