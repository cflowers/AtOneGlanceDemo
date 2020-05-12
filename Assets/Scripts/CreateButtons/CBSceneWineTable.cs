
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


public class CBSceneWineTable : AbstractCBScene
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
        createWineBottleButton();
        createFullGlassButton();
        createEmptyGlassButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    private void createWineBottleButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-90, 68);
         if (!(Inspection.getWineBottleInsp()))
        c.createButtons("buttonWineBottle", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_WineBottle(); }),
          false, true);
          else if (Inspection.getWineBottleInsp())
        c.createButtons("buttonWineBottle", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_WineBottle(); }),
          false,false);
    }

    private void createFullGlassButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(32, -62);
          if (!(Inspection.getWineGlassFInsp()))
        c.createButtons("buttonGlassF", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_WineFullG(); }),
          false, true);
         else if (Inspection.getWineGlassFInsp())
             c.createButtons("buttonGlassF", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_WineFullG(); }),
          false, true);
    }

    private void createEmptyGlassButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
        dicAnchor["buttonPos"] = new Vector2(130, 180);
         if (!(Inspection.getWineGlassEInsp()))
        c.createButtons("buttonGlassE", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_WineEmptyG(); }),
          false, true);
        else if ((Inspection.getWineGlassEInsp()))
        c.createButtons("buttonGlassE", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_WineEmptyG(); }),
          false, false);
    }

    private void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(206, 22);
        c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
          true, true);
    }

    public void lis_WineBottle()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().wineTable_bottle();
        d.done = false;
    }

    public void lis_WineFullG()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().wineTable_full_glass();
        d.done = false;
    }

    public void lis_WineEmptyG()
    {
        playClip(hardClip);
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().wineTable_empty_glass();
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


