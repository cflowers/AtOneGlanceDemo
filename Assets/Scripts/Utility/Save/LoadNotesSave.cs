using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    [Serializable]
	public class LoadNotesSave
	{
        ItemsFactory item;
        float posX;
        float posY;
        string panel;

        public LoadNotesSave(string panel, ItemsFactory item, float posX, float posY)
        {
            this.panel = panel;
            this.item = item;
            this.posX = posX;
            this.posY = posY;
        }

        public ItemsFactory Item
        {
            get { return item; }
            set { item = value; }
        }

        public float PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public float PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public string Panel
        {
            get { return panel; }
            set { panel = value; }
        }

	}

