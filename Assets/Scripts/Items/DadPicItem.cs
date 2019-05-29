using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class DadPicItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_DadPic");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/dadPic");

    }
}
