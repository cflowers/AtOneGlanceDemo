﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneFPMessLog : AbstractCBScene
{
    private Done d;
    private CreateButton c = new CreateButton();
    private ItemsFactory item;

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }

    public void getSceneButtons()
    {

        c.setCanvas("canvas");
        createLogButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createLogButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(0, 0);
        if (!(Inspection.getLog()))
        c.createButtons("buttonLog", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_log(); }),
          false, true);
        else if (Inspection.getLog())
         c.createButtons("buttonLog", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_log(); }),
          false, false);
    }

  
    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(206, 22);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    public void lis_log()
    {
        destroyButtons();
        GameObject tb = GameObject.FindGameObjectWithTag("canvas");
       // tb.GetComponent<TextBox>().textBool = true;
        item = new LogItem();
      //  this.item.beginText();
        this.item.loadImage();
         JsonBuffer jsonBuffer = new JsonBuffer();
        jsonBuffer.setToggleText("Log");  
        //tb.GetComponent<DisplayText>().readLine = true;
        tb.GetComponent<DisplayText>().item = item;
        tb.GetComponent<DisplayText>().popUpNow();
        Inspection.setLog(true);
    }

  
    public void lis_back()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


