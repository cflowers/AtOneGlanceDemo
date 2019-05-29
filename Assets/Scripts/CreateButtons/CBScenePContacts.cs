using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class CBScenePContacts : AbstractCBScene
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
        createFareedButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }


    private void createFareedButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(0, 120);
        c.createButtons("buttonFareed", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_message_fareed(); }),
          false, true);
    }


    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(206, 22);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    public void lis_message_fareed()
    {

        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("fareedMess1");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        bg.GetComponent<Background>().purplePhone_fareed();
        d.done = false;
    }

    public void lis_back()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("contactFareed");
        img.GetComponent<RawImage>().enabled = false;
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


