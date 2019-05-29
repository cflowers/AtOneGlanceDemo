﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class PictureLeftItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_PictureLeft");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/fareedLisa");

    }
}
