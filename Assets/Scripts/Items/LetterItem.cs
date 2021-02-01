﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class LetterItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Letter");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/letter");

    }

public override string[] whichToggle(){
        string[] list = {"1","2","4"};
        return list;
    }
}
