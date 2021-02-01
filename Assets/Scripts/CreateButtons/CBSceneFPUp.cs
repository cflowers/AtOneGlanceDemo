
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneFPUp : AbstractCBScene
{
    Done d;
    ItemsFactory item;
    CreateButton c = new CreateButton();

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }

    public void getSceneButtons()
    {
        c.setCanvas("canvas");
        createInspectBoomBoxButton();
        createInspectPictureLeftButton();
        createInspectPictureRightButton();
        createInspectHiddenPhoneButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createInspectBoomBoxButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(6, -33);
        if (!(Inspection.getBoomBox()))
        c.createButtons("buttonBoomBox", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetBoomBox(); }),
          false, true);
        else if (Inspection.getBoomBox())
        c.createButtons("buttonBoomBox", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetBoomBox(); }),
          false, false);
    }

    private void createInspectPictureLeftButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(302, 10);
         if (!(Inspection.getFPPicLInsp()))
        c.createButtons("buttonPicLeft", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetPicL(); }),
          false, true);
        else if (Inspection.getFPPicLInsp())
        c.createButtons("buttonPicLeft", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetPicL(); }),
          false, false);
    }

    private void createInspectPictureRightButton()
    {
        dicAnchor["anchorMin"] = new Vector2(1f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(1f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-260, 10);
          if (!(Inspection.getFPPicRInsp()))
        c.createButtons("buttonPicRight", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetPicR(); }),
          false, true);
        else if (Inspection.getFPPicRInsp())
        c.createButtons("buttonPicRight", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetPicR(); }),
          false, false);
    }

    private void createInspectHiddenPhoneButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(355, 285);
        c.createButtons("buttonHidPhone", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetPhone(); }),
          false, true);
    }

    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(4, 51);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }


    public void lis_GetBoomBox()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().boomBoxOpen();
        d.done = false;
    }


    public void lis_GetPicL()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceUp_picL();
        d.done = false;
    }

    public void lis_GetPicR()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceUp_picR();
        d.done = false;
    }

    public void lis_GetPhone()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceUp_phone();
        d.done = false;
    }

    public void lis_back()
    {

        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;
    }

}


