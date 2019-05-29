using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class PictureRightItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_PictureRight");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/fareedLisaLaughing");

    }
}
