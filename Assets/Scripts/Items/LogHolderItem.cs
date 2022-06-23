using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class LogHolderItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_LogHolder");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/logholder");

    }

     public override string[] whichToggle(){
        return base.whichToggle();
    }
}
