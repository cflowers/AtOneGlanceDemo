using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class CBSceneStacy2 : AbstractCBScene
{
    private Done d;
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
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createZoomButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-43, 18);
        if (!(Inspection.getStacyMess2()))
        c.createButtons("buttonZoom", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate {lis_zoom(); }),
          false, true);
        if (Inspection.getStacyMess2())
        c.createButtons("buttonZoom", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_zoom(); }),
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

    public void lis_zoom()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("stacyMess2Zm");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        item = new StacyItem2();
        this.item.beginText();
        this.item.loadImage();
        bg.GetComponent<Background>().goldPhone_stacy_zm2();
        d.done = false;
        bg.GetComponent<DisplayText>().item = item;
        bg.GetComponent<DisplayText>().popUpPhoneStacy2();
        Inspection.setStacyMess2(true);
    }

    public void lis_message()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("stacyMess2");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        bg.GetComponent<Background>().goldPhone_stacy_mess2();
        d.done = false;
    }

    public void lis_back()
    {
        destroyButtons();
        GameObject img = GameObject.FindGameObjectWithTag("stacyMess2");
        img.GetComponent<RawImage>().enabled = false;
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


