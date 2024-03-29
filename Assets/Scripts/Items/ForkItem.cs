﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class ForkItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Fork");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/fork");

    }

    public override string[] whichToggle(){
        return base.whichToggle();
    }
}
