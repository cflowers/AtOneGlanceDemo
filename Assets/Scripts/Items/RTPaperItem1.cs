using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class RTPaperItem1 : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_RTPaper1");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/papersright1");

    }
}
