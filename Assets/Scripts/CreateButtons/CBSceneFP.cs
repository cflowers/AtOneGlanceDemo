using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneFP : AbstractCBScene
{
    private Done d;
   // private CreateButton c = new CreateButton();
   

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneFPButtons();
    }

    public void getSceneFPButtons()
    {
       
        c.setCanvas("canvas");
        Dictionary<string, Vector2> dicAnchor = new Dictionary<string, Vector2>();
        createFPUpButton();
        createFPDownButton();
        createFPRightButton();
        createFPLeftButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createFPUpButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(36, 28);
         if (Inspection.getFPPhone() == false ||Inspection.getFPPicLInsp() == false || Inspection.getFPPicRInsp() == false)
        c.createButtons("buttonFPUp", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_FPUp(); }),
          false, true);
        else if (Inspection.getFPPhone() && Inspection.getFPPicLInsp() && Inspection.getFPPicRInsp())
        c.createButtons("buttonFPUp", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_FPUp(); }),
          false, false);
    }

    private void createFPDownButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(36, 22);
        if(Inspection.getMapInsp() == false || Inspection.getLetterInsp() == false)
        c.createButtons("buttonFPDown", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_FPDown(); }),
          false, true);
        else if(Inspection.getMapInsp() && Inspection.getLetterInsp())
        c.createButtons("buttonFPDown", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_FPDown(); }),
          false, false);
    }

    private void createFPRightButton()
    {
        dicAnchor["anchorMin"] = new Vector2(1f, 0f);
        dicAnchor["anchorMax"] = new Vector2(1f, 0f);
        dicAnchor["buttonPos"] = new Vector2(-322, 161);
        c.createButtons("buttonFPRight", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_FPRight(); }),
          false, true);
    }

    private void createFPLeftButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(382, -230);
        c.createButtons("buttonFPLeft", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_FPLeft(); }),
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

    public void lis_FPUp()
    {
        destroyButtons();
        stopFireAnimation();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceUp();
        d.done = false;
    }

    public void lis_FPDown()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceDown();
        d.done = false;
    }

    public void lis_FPRight()
    {
        destroyButtons();
        stopFireAnimation();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceRight();
        d.done = false;
    }

    public void lis_FPLeft()
    {
        destroyButtons();
        stopFireAnimation();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceLeft();
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


