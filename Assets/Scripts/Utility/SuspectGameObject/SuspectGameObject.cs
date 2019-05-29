using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


	public interface SuspectGameObject
	{
        string getBtnName();
        string getPanelName();
        bool Entered { get; set; }
        Texture2D getImg();
        Button Btn { get; set; }
        Image BtnImg { get; set; }
        
	}

