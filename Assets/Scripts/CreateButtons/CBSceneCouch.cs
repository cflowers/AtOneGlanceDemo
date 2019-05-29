
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneCouch : AbstractCBScene
{
    private Done d;
    private CreateButton c = new CreateButton();
    private ItemsFactory item;

    public override void placing(Done d, Done d2, bool sceneBool)
    {
        this.d = d;
        if (!(d.done) && sceneBool)
            getSceneCouchButtons();
    }

    public void getSceneCouchButtons()
    {

        c.setCanvas("canvas");
        createCouchPillowButton();
        createCouchBookButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createCouchPillowButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-90, 99);
        c.createButtons("buttonPillow", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_pillow(); }),
          false, true);
    }

    private void createCouchBookButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(-27, 59);
        c.createButtons("buttonBook", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_book(); }),
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

    public void lis_pillow()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().couchPillow();
        d.done = false;
    }

    public void lis_book()
    {
        playClip(bookClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().couchBook();
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


