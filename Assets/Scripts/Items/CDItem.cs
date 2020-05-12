using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class CDItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_CD");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/couchcd");

    }

    public override string[] whichToggle(){
    string[] list = {"1","2","4"};
        return list;
    }
}
