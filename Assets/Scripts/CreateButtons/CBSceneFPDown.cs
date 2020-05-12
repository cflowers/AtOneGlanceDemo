using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneFPDown : AbstractCBScene
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
        createInspectLetterButton();
        createInspectMapButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createInspectLetterButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(248, -104);
        if (!(Inspection.getLetterInsp()))
        c.createButtons("buttonLetter", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetLetter(); }),
          false, true);
         else if (Inspection.getLetterInsp())
        c.createButtons("buttonLetter", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetLetter(); }),
          false, false);
    }

    private void createInspectMapButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-222, -160);
         if (!(Inspection.getMapInsp()))
        c.createButtons("buttonMap", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetMap(); }),
          false, true);
        else if (Inspection.getMapInsp())
        c.createButtons("buttonMap", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_GetMap(); }),
          false, false);
    }

    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
        dicAnchor["buttonPos"] = new Vector2(3, -210);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    public void lis_GetLetter()
    {
        playClip(paperClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceDown_letter();
        d.done = false;
    }

    public void lis_GetMap()
    {
        playClip(paperClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fireplaceDown_map();
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


