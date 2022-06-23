using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class CupItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_CupLook");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/cuplook");

    }

    public override string[] whichToggle(){
        return base.whichToggle();
    }
}
