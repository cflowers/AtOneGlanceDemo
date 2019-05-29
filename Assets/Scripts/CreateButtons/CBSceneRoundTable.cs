
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneRoundTable : AbstractCBScene
{
    private Done d;
    private CreateButton c = new CreateButton();

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }

    public void  getSceneButtons()
    {
        c.setCanvas("canvas");
        createPhoneButton();
        createPapersButton();
        createBookCaseButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createPhoneButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(39, 218);
        c.createButtons("buttonPhone", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_phone(); }),
          false, true);
    }

    private void createPapersButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(298, 112);
        c.createButtons("buttonPapers", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_papers(); }),
          false, true);
    }

    private void createBookCaseButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(423, 107);
        c.createButtons("buttonBookCase", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_pbookcase(); }),
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

    public void lis_phone()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().goldPhone();
        d.done = false;
    }

    public void lis_papers()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().rtPapers();
        d.done = false;
    }

    public void lis_pbookcase()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().p_bookcase();
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


