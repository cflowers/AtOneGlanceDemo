using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class StatueItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Statue");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/statue");

    }
}
