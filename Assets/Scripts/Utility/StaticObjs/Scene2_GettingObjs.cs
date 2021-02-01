using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

	public class Scene2_GettingObjs :MonoBehaviour
	{
        static Scene2_GettingObjs m_instance;
        GameObject canvas;
        GameObject hud_points;
        GameObject popUp;
        GameObject keyboardButton;
        GameObject winIcon;
        GameObject suspectScreen;
        GameObject screen;
        GameObject suspect;
        GameObject recSuspect;
        GameObject buttonsInter;
        GameObject input;
        GameObject btnImg;

        void Awake()
        {
            assignInstance();
            canvas = GameObject.FindGameObjectWithTag("canvas");
            hud_points = GameObject.FindGameObjectWithTag("points");
            popUp = GameObject.FindGameObjectWithTag("popup");
            keyboardButton = GameObject.FindGameObjectWithTag("keyboardButton");
            winIcon = GameObject.FindGameObjectWithTag("winIcon");
            suspectScreen = GameObject.FindGameObjectWithTag("suspectScreen");
            screen = GameObject.FindGameObjectWithTag("screen");
            suspect = GameObject.FindGameObjectWithTag("enterSuspect");
            recSuspect = GameObject.FindGameObjectWithTag("recSuspect1");
            buttonsInter = GameObject.FindGameObjectWithTag("nextPanel");
            input = GameObject.FindGameObjectWithTag("inputSuspect");
            btnImg = GameObject.FindGameObjectWithTag("lisaBtn");
        }

        void assignInstance()
        {
            if (m_instance != null && m_instance != this)
                Destroy(this);
            else
                m_instance = this;
        }

        // Use this Method to access your objects
        public static Scene2_GettingObjs getObjs()
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

        public GameObject KeyboardButton
        {
            get { return keyboardButton; }
            set { keyboardButton = value; }
        }

        public GameObject WinIcon
        {
            get { return winIcon; }
            set { winIcon = value; }
        }

        public GameObject SuspectScreen
        {
            get { return suspectScreen; }
            set { suspectScreen = value; }
        }

        public GameObject Screen
        {
            get { return screen; }
            set { screen = value; }
        }

        public GameObject Suspect
        {
            get { return suspect; }
            set { suspect = value; }
        }

        public GameObject RecSuspect
        {
            get { return recSuspect; }
            set { recSuspect = value; }
        }

        public GameObject ButtonsInter
        {
            get { return buttonsInter; }
            set { buttonsInter = value; }
        }

        public GameObject Input
        {
            get { return input; }
            set { input = value; }
        }

           public GameObject Hud_Points
        {
            get { return hud_points; }
            set { hud_points = value; }
        }
     
	}

