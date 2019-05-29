
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class CBSceneGoldPhone : AbstractCBScene
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
            createPhoneButton();
            createBackButton();
            d.done = true;
            base.setButtons(c.getButtons());
        
    }

    private void createPhoneButton()
    {
        dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
        dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
        dicAnchor["buttonPos"] = new Vector2(36, 28);
        c.createButtons("buttonContacts", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_contacts(); }),
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

    public void lis_contacts()
    {
        destroyButtons();
      
        GameObject img = GameObject.FindGameObjectWithTag("contacts");
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        img.GetComponent<RawImage>().enabled = true;
        bg.GetComponent<Background>().goldPhone_contacts();
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


