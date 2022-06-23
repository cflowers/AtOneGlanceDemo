using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class LogItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Body");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/log");

    }

     public override string[] whichToggle(){
        return base.whichToggle();
    }
}
