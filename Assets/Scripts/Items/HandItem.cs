using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class HandItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Hand");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/victim_hand");

    }

     public override string[] whichToggle(){
        string[] list = {"1","4"};
        return list;
    }
}
