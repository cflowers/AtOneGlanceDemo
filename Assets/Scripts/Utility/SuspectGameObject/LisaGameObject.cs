using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class LisaGameObject : SuspectGameObject
{
    bool entered = false;
     [System.NonSerialized]
    Texture2D img;
     [System.NonSerialized]
    Button btn = GameObject.FindGameObjectWithTag("lisaBtn").GetComponent<Button>();
     [System.NonSerialized]
    Image btnImg = GameObject.FindGameObjectWithTag("lisaBtn").GetComponent<Image>();

    public string getBtnName()
    {
        return "lisaBtn";
    }

    public string getPanelName()
    {
        return "placeHolderLisa";
    }

    public bool Entered
    {
        get { return entered; }
        set { entered = value; }
    }

    public Texture2D getImg()
    {
        img = Resources.Load<Texture2D>("Suspects/victim");
        return img;
    }

    public Button Btn
    {
        get { return btn; }
        set { btn = value; }
    }

    public Image BtnImg
    {
        get { return btnImg; }
        set { btnImg = value; }
    }
}

