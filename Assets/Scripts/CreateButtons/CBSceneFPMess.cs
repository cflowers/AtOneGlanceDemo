
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneFPMess : AbstractCBScene
{
    private Done d;
    private CreateButton c = new CreateButton();
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
        createLogButton();
        createPaper1Button();
        createPaper2Button();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createLogButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
        dicAnchor["buttonPos"] = new Vector2(-146, -246);
        c.createButtons("buttonLog", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_log(); }),
          false, true);
    }

    private void createPaper1Button()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
        dicAnchor["buttonPos"] = new Vector2(36, -167);
        c.createButtons("buttonPaper1", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_fpMessPaper1(); }),
          false, true);
    }

    private void createPaper2Button()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(-15, 175);
        c.createButtons("buttonPaper2", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_fpMessPaper2(); }),
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

    public void lis_log()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpMessLog();
        d.done = false;
    }

    public void lis_fpMessPaper1()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpMessPaper1();
        d.done = false;
    }

    public void lis_fpMessPaper2()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().fpMessPaper2();
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


