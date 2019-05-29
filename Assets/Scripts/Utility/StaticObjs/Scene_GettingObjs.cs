using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    /**
     * A singleton class that holds
     * game objects that will be used frequently
     * throughout the scene
     */ 
	public class Scene_GettingObjs :MonoBehaviour
	{
        static Scene_GettingObjs m_instance;
        GameObject canvas;
        GameObject hud_points;
        GameObject popUp;
        GameObject phonePopUp;
        GameObject saveWindow;
        GameObject loadWindow;
        GameObject notebook;
        GameObject notebookToggle;

        void Awake()
        {
            assignInstance();
            canvas = GameObject.FindGameObjectWithTag("canvas");
            hud_points = GameObject.FindGameObjectWithTag("points");
            popUp = GameObject.FindGameObjectWithTag("popup");
            phonePopUp = GameObject.FindGameObjectWithTag("phonePopUp");
            saveWindow = GameObject.FindGameObjectWithTag("saveWindow");
            loadWindow = GameObject.FindGameObjectWithTag("loadWindow");
            notebook = GameObject.FindGameObjectWithTag("notebook");
            notebookToggle = GameObject.FindGameObjectWithTag("notebookToggle");
        }

        void assignInstance()
        {
            if (m_instance != null && m_instance != this)
                Destroy(this);
            else
                m_instance = this;
        }

        // Use this Method to access your objects
        public static Scene_GettingObjs getObjs()
        {
            return m_instance;
        }

        public GameObject Canvas
        {
            get { return canvas; }
            set { canvas = value; }
        }

        public GameObject PopUp
        {
            get { return popUp; }
            set { popUp = value; }
        }

        public GameObject PhonePopUp
        {
            get { return phonePopUp; }
            set { phonePopUp = value; }
        }

        public GameObject SaveWindow
        {
            get { return saveWindow; }
            set { saveWindow = value; }
        }


        public GameObject LoadWindow
        {
            get { return loadWindow; }
            set { loadWindow = value; }
        }


        public GameObject Hud_points
        {
            get { return hud_points; }
            set { hud_points = value; }
        }

        public GameObject NotebookToggle
        {
            get { return notebookToggle; }
            set { notebookToggle = value; }
        }


        public GameObject Notebook
        {
            get { return notebook; }
            set { notebook = value; }
        }

       
       
     
	}

