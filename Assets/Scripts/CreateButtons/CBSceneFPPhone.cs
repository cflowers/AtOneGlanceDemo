using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CBSceneFPPhone : AbstractCBScene
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
        createPhoneButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }


    private void createPhoneButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(239, 131);
        c.createButtons("buttonContacts", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_contacts(); }),
         false, true);
     
    }

    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(100, 70);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    public void lis_contacts()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("contactFareed");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        bg.GetComponent<Background>().purplePhone_contacts();
        d.done = false;
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

