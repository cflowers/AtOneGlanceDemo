using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class ShovelItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Shovel");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/shovel");

    }
}
