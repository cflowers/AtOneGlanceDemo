using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class DadItem1 : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_Dad_Message1");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/goldPhone2");

    }

    public override string[] whichToggle(){
        string[] list = {"1","2","3","4"};
        return list;
    }
}
