using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

    [Serializable]
	public class FareedGameObject : SuspectGameObject
	{
        bool entered = false;
         [System.NonSerialized]
        Texture2D img;
         [System.NonSerialized]
        Button btn =GameObject.FindGameObjectWithTag("fareedBtn").GetComponent<Button>();
         [System.NonSerialized]
        Image btnImg =GameObject.FindGameObjectWithTag("fareedBtn").GetComponent<Image>();

        public string getBtnName()
        {
            return "fareedBtn";
        }

        public string getPanelName()
        {
            return "placeHolderFareed";
        }

        public bool Entered
        {
            get { return entered; }
            set { entered = value; }
        }

        public Texture2D getImg()
        {
            img = Resources.Load<Texture2D>("Suspects/suspect_fareed");
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

