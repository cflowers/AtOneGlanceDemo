using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using System.IO;
using UnityEngine.UI;


public class CBSceneEnvZoom : AbstractCBScene
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
        createEnvelopeContButton();
        createBackButton();
        d.done = true;
        base.setButtons(c.getButtons());
    }

    void createEnvelopeContButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(-58, -109);
        CreateButtonsContents cont = new CreateButtonsContents();
        cont.Name = "buttonEnvCont";
        cont.Parent =c.getCanvas().GetComponent<Canvas>().transform;
        cont.DicAnchors = dicAnchor;
        cont.Lis = new UnityAction(delegate {lis_envelopeContents();});
        cont.ShowButton = false;
        cont.Interact = true;
        cont.Inspection = Inspection.getEnvelopeInsp();
        buttonsDic["map"]= cont;
        //c.createButtons("buttonEnvCont",c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate {lis_envelopeContents();}),
         //false, true);
        c.createButtons(buttonsDic);
    }

    void createBackButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0f, 0f);
        dicAnchor["anchorMax"] = new Vector2(0f, 0f);
        dicAnchor["buttonPos"] = new Vector2(90, 70);
        CreateButtonsContents cont = new CreateButtonsContents();
        cont.Name = "buttonBack";
        cont.Parent = c.getCanvas().GetComponent<Canvas>().transform;
        cont.DicAnchors = dicAnchor;
        cont.Lis = new UnityAction(delegate { lis_back(); });
        cont.ShowButton = true;
        cont.Interact = true;
        cont.Inspection = false;
        buttonsDic["map"] = cont;
        c.createButtons(buttonsDic);
       // c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
        // true, true);
    }

    void lis_envelopeContents()
    {
        
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().envelopeContents();
       
        //d.done = false;
        item = new EnvelopeItem();
        this.item.loadImage();
        this.item.beginText();
        JsonBuffer jsonBuffer = new JsonBuffer();
        jsonBuffer.setToggleText("Envelope");  
        bg.GetComponent<DisplayText>().item = item;
        bg.GetComponent<DisplayText>().popUpNow();
        Inspection.setEnvelopeInsp(true);
        
    }

  

    void lis_back()
    {
        destroyButtons();
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        d.done = false;
    }

}