using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class EnvelopeItem : AbstractItems
{

 
    public override void beginText()
    {
        base.begin("Text/ExaminingEnvContents");
    }

    public override bool getWrite()
    {
        return true;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/envelope");

    }

    public override void setItemDesc(string itemDesc)
    {
        base.setItemDesc(itemDesc);
    }

    public override string[] whichToggle(){
        string[] list = {"1","2"};
        return list;
    }
}
