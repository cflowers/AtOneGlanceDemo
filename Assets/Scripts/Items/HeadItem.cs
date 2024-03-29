﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class HeadItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Head");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/head");

    }

    public override string[] whichToggle(){
        return base.whichToggle();
    }
}
