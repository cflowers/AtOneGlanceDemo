using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class BroomItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Broom");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/broom");

    }
}
