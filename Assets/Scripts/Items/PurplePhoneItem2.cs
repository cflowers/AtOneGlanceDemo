using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class PurplePhoneItem2 : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Fareed_Message2");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/fareedPhone2");

    }
}
