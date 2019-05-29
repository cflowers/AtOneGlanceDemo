﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class PurplePhoneItem1 : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Fareed_Message1");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/fareedPhone1");

    }
}
