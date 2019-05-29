using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBScenePurpleBookCase : AbstractCBScene
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
        createPurpleBookCaseButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createPurpleBookCaseButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(39, -61);
        if (!(Inspection.getPBookcaseInsp()))
        c.createButtons("buttonPBookCase", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_PBookCase(); }),
          false, true);
        else if (Inspection.getPBookcaseInsp())
            c.createButtons("buttonPBookCase", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_PBookCase(); }),
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

    public void lis_PBookCase()
    {
        destroyButtons();
        GameObject tb = GameObject.FindGameObjectWithTag("canvas");   
        tb.GetComponent<TextBox>().textBool = true;
        item = new PBookcaseItem();
        this.item.beginText();
        this.item.loadImage();
        //tb.GetComponent<DisplayText>().readLine = true;
        tb.GetComponent<DisplayText>().item = item;
        tb.GetComponent<DisplayText>().popUpNow();
        Inspection.setPBookcaseInsp(true);
       
    }


    public void lis_back()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


