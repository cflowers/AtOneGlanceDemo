using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneShelfLeft : AbstractCBScene
{
    Done d;

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }

    void getSceneButtons()
    {
        c.setCanvas("canvas");
        createClkButton();
        createTigerButton();
        createGlobeButton();
        createBooksButton();
        createBlueBookCaseButton();
        createGreenBookCaseButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    void createClkButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(20, 185);
        c.createButtons("buttonClk", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_clk(); }),
          false, true);
    }

    void createTigerButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-123, -157);
        c.createButtons("buttonTiger", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_tiger(); }),
          false, true);
    }

    void createGlobeButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(63, -157);
        c.createButtons("buttonGlobe", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_globe(); }),
          false, true);
    }

    void createBooksButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(5, 33);
        c.createButtons("buttonBooks", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_books(); }),
          false, true);
    }


    void createBlueBookCaseButton()
    {
        dicAnchor["anchorMin"] = new Vector2(1f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(1f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-228, 0);
        c.createButtons("buttonBlueBookCase", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_blue_book_case(); }),
          false, true);
    }

    void createGreenBookCaseButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(195, 0);
        c.createButtons("buttonGreenBookCase", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_green_book_case(); }),
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

    void lis_clk()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().clock();
        d.done = false;
    }

    void lis_tiger()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().tiger();
        d.done = false;
    }

    void lis_globe()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().globe();
        d.done = false;
    }

    void lis_books()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().slBooks();
        d.done = false;
    }


    void lis_blue_book_case()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().b_bookcase();
        d.done = false;
    }


    void lis_green_book_case()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().g_bookcase();
        d.done = false;
    }

    void lis_back()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;

    }

}


