
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneSLBooks : AbstractCBScene
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
        createBookZmButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    void createBookZmButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(36, 28);
        c.createButtons("buttonBook", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate {lis_book_zoom(); }),
          false, true);
    }


    void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(206, 22);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    public void lis_book_zoom()
    {
        playClip(bookClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().anthraxBook();
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


