
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneHand : AbstractCBScene
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
        createBodyButton();
        createHandButton();
        createGunButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createBodyButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
        dicAnchor["buttonPos"] = new Vector2(-71, -149);
        c.createButtons("buttonBody", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_body(); }),
          false, true);
    }

    private void createGunButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(-173, 199);
        c.createButtons("buttonGun", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_gun(); }),
         false, true);
    }

    private void createHandButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(30, 216);
        if (!(Inspection.getHandInsp()))
            c.createButtons("buttonHand", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_hand(); }),
            false, true);
        else if (Inspection.getHandInsp())
            c.createButtons("buttonHand", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_hand(); }),
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

    public void lis_body()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().body();
        d.done = false;
    }


    private void lis_gun()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().gun();
        d.done = false;
    }


    public void lis_hand()
    {
        destroyButtons();
        GameObject tb = GameObject.FindGameObjectWithTag("canvas"); 
       // tb.GetComponent<TextBox>().textBool = true;
        item = new HandItem();
        //this.item.beginText();
        this.item.loadImage();
        JsonBuffer jsonBuffer = new JsonBuffer();
        jsonBuffer.setToggleText("Hand");  
        tb.GetComponent<DisplayText>().item = item;
        tb.GetComponent<DisplayText>().popUpNow();
        Inspection.setHandInsp(true);
      
    }

    public void lis_back()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


