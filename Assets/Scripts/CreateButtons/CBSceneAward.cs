
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneAward : AbstractCBScene
{
    Done d;
    ItemsFactory item;

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }


    void getSceneButtons()
    {
       
        c.setCanvas("canvas");
        createAwardZmButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createAwardZmButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(36, 28);
        c.createButtons("buttonAward", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate {lis_award_zoom(); }),
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

    void lis_award_zoom()
    {
       
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().awardZm();
        //d.done = false;
        item = new AwardItem();
        this.item.loadImage();
        bg.GetComponent<DisplayText>().item = item;
        bg.GetComponent<DisplayText>().popUpNow();
        Inspection.setAward(true);
    }

    void lis_back()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


