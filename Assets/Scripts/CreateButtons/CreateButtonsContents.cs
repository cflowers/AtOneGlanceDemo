using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

	public class CreateButtonsContents
	{

        string name;
        Transform parent;
        Dictionary<string, Vector2> dicAnchors;
        UnityAction lis;
        bool showButton;
        bool interact;
        bool inspection;

        public bool Inspection
        {
            get { return inspection; }
            set { inspection = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Transform Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public Dictionary<string, Vector2> DicAnchors
        {
            get { return dicAnchors; }
            set { dicAnchors = value; }
        }

        public UnityAction Lis
        {
            get { return lis; }
            set { lis = value; }
        }

        public bool ShowButton
        {
            get { return showButton; }
            set { showButton = value; }
        }

        public bool Interact
        {
            get { return interact; }
            set { interact = value; }
        }

	}

