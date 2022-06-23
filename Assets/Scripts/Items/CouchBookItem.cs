using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class CouchBookItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_CouchBook");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/couchbook");

    }

     public override string[] whichToggle(){
    string[] list = {"2"};
        return list;
    }
}
