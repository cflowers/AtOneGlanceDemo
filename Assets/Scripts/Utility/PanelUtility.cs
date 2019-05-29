using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class PanelUtility
{

    string name;
    GameObject panel;

    public PanelUtility(string name, GameObject panel)
    {
        this.name = name;
        this.panel = panel;
    }

    public GameObject Panel
    {
        get { return panel; }
        set { panel = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

