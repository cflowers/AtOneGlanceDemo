
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneWineBottle : AbstractCBScene
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
        createWineBottleButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createWineBottleButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-24, 0);
        if (!(Inspection.getWineBottleInsp()))
        c.createButtons("buttonWineBottle", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_Inspection(); }),
          false, true);
        else if (Inspection.getWineBottleInsp())
            c.createButtons("buttonWineBottle", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_Inspection(); }),
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

    private void lis_Inspection()
    {
        destroyButtons();
        GameObject tb = GameObject.FindGameObjectWithTag("canvas");
      //  tb.GetComponent<TextBox>().textBool = true;
        item = new WineBottleItem();
      //  this.item.beginText();
        this.item.loadImage();
        JsonBuffer jsonBuffer = new JsonBuffer();
        jsonBuffer.setToggleText("WineBottle");  
        //tb.GetComponent<DisplayText>().readLine = true;
        tb.GetComponent<DisplayText>().item = item;
        tb.GetComponent<DisplayText>().popUpNow();
        Inspection.setWineBottleInsp(true);

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


