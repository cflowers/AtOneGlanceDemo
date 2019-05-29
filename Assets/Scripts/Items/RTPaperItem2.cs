using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class RTPaperItem2 : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_RTPaper2");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/papersright2");

    }
}
