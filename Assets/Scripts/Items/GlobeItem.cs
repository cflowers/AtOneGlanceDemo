using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class GlobeItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Globe");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/globe");

    }

    public override string[] whichToggle(){
        return base.whichToggle();
    }
}
