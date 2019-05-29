using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneFPLeft : AbstractCBScene
{
    private Done d;
    private CreateButton c = new CreateButton();

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneButtons();
    }




    public void getSceneButtons()
    {
       
        c.setCanvas("canvas");
        createShovelButton();
        createPickButton();
        createBroomButton();
        createForkButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createShovelButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-140, 83);
        c.createButtons("buttonShovel", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_shovel(); }),
          false, true);
    }

    private void createPickButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-189, 249);
        c.createButtons("buttonPick", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_pick(); }),
          false, true);
    }

    private void createBroomButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-82, 233);
        c.createButtons("buttonBroom", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_broom(); }),
          false, true);
    }

    private void createForkButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(20, 87);
        c.createButtons("buttonFork", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_fork(); }),
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

    public void lis_shovel()
    {
        playClip(metalClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpAccShovel();
        d.done = false;
    }

    public void lis_pick()
    {
        playClip(metalClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpAccPick();
        d.done = false;
    }

    public void lis_broom()
    {
        playClip(metalClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpAccBroom();
        d.done = false;
    }

    public void lis_fork()
    {
        playClip(metalClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpAccFork();
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


