using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;


public class Hover : EventTrigger
{
    private MouseCursor mc;
    private Background bg;
  
    void Start()
    {
        mc = GameObject.FindGameObjectWithTag("mc").GetComponent<MouseCursor>();
        bg = GameObject.FindGameObjectWithTag("canvas").GetComponent<Background>();   
    }

    // when highlighted with mouse.
    public override void OnPointerEnter(PointerEventData eventData)
    {
        GameObject g = eventData.pointerCurrentRaycast.gameObject;

        //Debug.Log("WR NAME:" + g.name);
      
        bool check = bg.wr.cursorCheckName(bg.wr.currentName);
        bool back = g.name == "buttonBack";

        if(back)
             mc.cursorTexture = mc.backTexture;
        else if (!back && check)
            mc.cursorTexture = mc.eyeTexture;
        else 
            mc.cursorTexture = mc.handTexture;

        mc.setCursor();
      //  Debug.Log("<color=red>Event:</color> Completed mouse highlight.");
    }

    //when exiting the button
    public override void OnPointerExit(PointerEventData eventData)
    {
        mc.cursorTexture = mc.origTexture;
        mc.setCursor();
    //    Debug.Log("<color=red>Event:</color> Completed mouse exit.");
    }


    public override void OnPointerClick(PointerEventData eventData)
    {
       
        mc.cursorTexture = mc.origTexture;
        mc.setCursor();
    //    Debug.Log("<color=red>Event:</color> Completed mouse exit.");
    }

    
}
