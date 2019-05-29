using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class OfficeBackground : MonoBehaviour
{

    /**
     * set initial background for level
     * each method returns a picture
     */
    RawImage rawImageComp;
    
    public Texture2D[] textures;
    public LinkedList<CrimeTex> linkedList;
    public OfficeWhichRoom wr = new OfficeWhichRoom();
    const int AT_COMP = 0;
    const int ON_COMP = 1;
 
    

    void Awake()
    {
        rawImageComp = GetComponentInChildren<RawImage>();
        rawImageComp.texture = textures[AT_COMP];
        linkedList = new LinkedList<CrimeTex>();
        linkedList.AddLast(new CrimeTex(textures[AT_COMP], "AT_COMP"));
        wr.fillMap();
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void atComp()
    {
        linkedList.AddLast(new CrimeTex(textures[AT_COMP], "AT_COMP"));
        rawImageComp.texture = textures[AT_COMP];
        wr.boolHandle(linkedList.Last.Value.name);

    }


    public void onComp()
    {
        linkedList.AddLast(new CrimeTex(textures[ON_COMP], "ON_COMP"));
        rawImageComp.texture = textures[ON_COMP];
        wr.boolHandle(linkedList.Last.Value.name);
    }

   
    public void back()
    {
        if (linkedList.Count > 1)
        {
            linkedList.RemoveLast();
            wr.boolHandle(linkedList.Last.Value.name);
            Texture2D tex = linkedList.Last.Value.tex;
            Debug.Log(tex);
            rawImageComp.texture = tex;
           
        }

    }

}
