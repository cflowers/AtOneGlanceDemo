using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class GoldPhoneItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Stacy_Message1");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/goldPhone");

    }
}
