using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class MapItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Map");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/map");

    }
}
