using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

    [Serializable]
	public class DadGameObject : SuspectGameObject
	{
        bool entered = false;
         [System.NonSerialized]
        Texture2D img;
         [System.NonSerialized]
        Button btn = GameObject.FindGameObjectWithTag("dadBtn").GetComponent<Button>();
         [System.NonSerialized]
        Image btnImg = GameObject.FindGameObjectWithTag("dadBtn").GetComponent<Image>();

        public string getBtnName()
        {
            return "dadBtn";
        }

        public string getPanelName()
        {
            return "placeHolderDad";
        }

        public bool Entered
        {
            get { return entered; }
            set { entered = value; }
        }

        public Texture2D getImg()
        {
            img = Resources.Load<Texture2D>("Suspects/suspect_father");
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

