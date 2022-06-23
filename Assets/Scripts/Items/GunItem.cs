using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class GunItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Gun");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/gun");

    }

     public override string[] whichToggle(){
        string[] list = {"1","4"};
        return list;
    }
}
