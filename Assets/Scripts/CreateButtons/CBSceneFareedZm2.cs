﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class CBSceneFareedZm2 : AbstractCBScene
{
    private Done d;
 
    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }


    void getSceneButtons()
    {
        c.setCanvas("phonePopUp");
        GameObject hud_points = GameObject.FindGameObjectWithTag("points");
        PhoneCompositor pc = new PhoneCompositor(c, hud_points, d, "fareedMess2Zm");
        pc.createPhoneWriteButton();
        pc.createPhoneDontWriteButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }
}


