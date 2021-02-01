using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CBSceneFPMap : AbstractCBScene
{
    private Done d;
    private ItemsFactory item;
    private CreateButton c = new CreateButton();


    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }



    private void getSceneButtons()
    {
        c.setCanvas("canvas");
        createInspectButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }


    private void createInspectButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(0, 0);
        if (!(Inspection.getMapInsp()))
            c.createButtons("buttonInspect", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_Inspection(); }),
              false, true);
        else if (Inspection.getMapInsp())
            c.createButtons("buttonInspect", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_Inspection(); }),
          false, false);
    }

    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(100, 70);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    private void lis_Inspection()
    {
        destroyButtons();
        GameObject tb = GameObject.FindGameObjectWithTag("canvas");
       // tb.GetComponent<TextBox>().textBool = true;
        item = new MapItem();
        //this.item.beginText();
        this.item.loadImage();
        JsonBuffer jsonBuffer = new JsonBuffer();
        jsonBuffer.setToggleText("Map");  
       // tb.GetComponent<DisplayText>().readLine = true;
        tb.GetComponent<DisplayText>().item = item;
        tb.GetComponent<DisplayText>().popUpNow();
        Inspection.setMapInsp(true);

    }

    private void lis_back()
    {
        destroyButtons();
        GameObject tb = GameObject.FindGameObjectWithTag("canvas");
        tb.GetComponent<TextBox>().textBool = false;
        tb.GetComponent<DisplayText>().readLine = false;
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}

