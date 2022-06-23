using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class ClockItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Clock");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/clock");

    }

     public override string[] whichToggle(){
        return base.whichToggle();
    }
}
