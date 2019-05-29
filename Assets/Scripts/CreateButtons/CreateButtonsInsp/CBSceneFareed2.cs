using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class CBSceneFareed2 : AbstractCBScene
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
        createZoomButton();
        createNextButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createZoomButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-43, 18);
        if (!(Inspection.getFareedMess2()))
        c.createButtons("buttonZoom", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate {lis_zoom(); }),
          false, true);
        if (Inspection.getFareedMess2())
        c.createButtons("buttonZoom", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_zoom(); }),
          false, false);
    }

    private void createNextButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(192, 0);
        c.createButtons("buttonNext", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_next(); }),
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

    public void lis_zoom()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("fareedMess2Zm");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        item = new PurplePhoneItem2();
        this.item.beginText();
        this.item.loadImage();
        bg.GetComponent<Background>().purplePhone_fareed_zm2();
        d.done = false;
        bg.GetComponent<DisplayText>().item = item;
        bg.GetComponent<DisplayText>().popUpPhoneFareed2();
        Inspection.setFareedMess2(true);
    }

    public void lis_next()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("fareedMess3");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        bg.GetComponent<Background>().purplePhone_fareed3();
        d.done = false;
    }

    public void lis_back()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("fareedMess2");
        img.GetComponent<RawImage>().enabled = false;
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


