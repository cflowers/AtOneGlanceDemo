using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class PickItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Pick");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/pick");

    }

     public override string[] whichToggle(){
        return base.whichToggle();
    }
}
