using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneShelfRight : AbstractCBScene
{
    private Done d;
   
    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }

    void getSceneButtons()
    {
        c.setCanvas("canvas");
        createCupButton();
        createJarButton();
        createHeadButton();
        createAwardButton();
        createDownButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createCupButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-102, 185);
        c.createButtons("buttonCup", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_cup(); }),
          false, true);
    }

    private void createJarButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(92, 186);
        c.createButtons("buttonJar", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_jar(); }),
          false, true);
    }

    private void createHeadButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-132, -157);
        c.createButtons("buttonHead", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_head(); }),
          false, true);
    }

    private void createAwardButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(89, -162);
        c.createButtons("buttonAward", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_award(); }),
          false, true);
    }


    private void createDownButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(0, 28);
        c.createButtons("buttonDown", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_down(); }),
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

    void lis_cup()
    {

        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().cup();
        d.done = false;
    }

    void lis_jar()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().jar();
        d.done = false;
    }

    void lis_head()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().head();
        d.done = false;
    }

    void lis_award()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().award();
        d.done = false;
    }


    void lis_down()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().statue();
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


