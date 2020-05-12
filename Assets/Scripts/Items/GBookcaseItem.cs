using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public class GBookcaseItem : AbstractItems
{

    public override void beginText()
    {
        base.begin("Text/Examine_BookCase");
    }

    public override bool getWrite()
    {
        return false;
    }

    public override void loadImage()
    {
        base.loadPic("Pics/bookCaseGreen");

    }

    public override string[] whichToggle(){
        return base.whichToggle();
    }
}
