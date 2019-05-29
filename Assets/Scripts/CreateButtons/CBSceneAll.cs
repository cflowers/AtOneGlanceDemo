﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;


	public class CBSceneAll: AbstractCBScene
	{
        Done d;
        bool alreadyHere = false;
       

        public override void placing(Done d, Done d2, bool sceneBool)
        {
            this.d = d;
            if(!(d.done) && sceneBool && !alreadyHere)
            getSceneButtons();
        }

        void getSceneButtons()
        {

            c.setCanvas("canvas");
                     
            //create buttons for scene(The whole room)
            createBackButton();
            createEnvButton();
            createFirePlaceButton();
            createWineButton();
            createBodyButton();
            createCouchButton();
            createFloorNearFPButton();
            createWallButton();
            createShelfLeftButton();
            createShelfRightButton();
            createLampButton();

            d.done = true;
            base.setButtons(c.getButtons());
        }

        private void createEnvButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0f);
            dicAnchor["buttonPos"] = new Vector2(-18, 26);
            CreateButtonsContents cont = new CreateButtonsContents();
            cont.Name = "buttonEnvelope";
            cont.Parent = c.getCanvas().GetComponent<Canvas>().transform;
            cont.DicAnchors = dicAnchor;
            cont.Lis = new UnityAction(delegate { lis_envelopeZoom(); });
            cont.ShowButton = false;
            cont.Interact = true;
            cont.Inspection = Inspection.getEnvelopeInsp();
            buttonsDic["map"] = cont;
            c.createButtons(buttonsDic);
            Debug.Log("Inspection" + buttonsDic["map"].Inspection);
           // c.createButtons("buttonEnvelope", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_envelopeZoom(); }),
             // false, true);
        }

        private void createFirePlaceButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-414, 49);
            c.createButtons("buttonFP", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_fireplace(); }),
              false, true);
        }

        private void createWineButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(22, -60);
            c.createButtons("buttonWG", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_table(); }),
             false, true);
        }


        private void createBodyButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-208, -75);
            c.createButtons("buttonBody", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_body(); }),
             false, true);
        }

        private void createCouchButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(126, 22);
            c.createButtons("buttonCouch", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_couch(); }),
             false, true);
        }

        private void createFloorNearFPButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-120, 34);
            c.createButtons("buttonNearFP", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_messfp(); }),
             false, true);
        }

        private void createWallButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
            dicAnchor["buttonPos"] = new Vector2(-136, -70);
            c.createButtons("buttonWall", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_wall(); }),
             false, true);
        }

        private void createShelfLeftButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
            dicAnchor["buttonPos"] = new Vector2(125, -99);
            c.createButtons("buttonShelfLeft", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_shelf_left(); }),
             false, true);
        }

        private void createShelfRightButton()
        {
            dicAnchor["anchorMin"] = new Vector2(1f, 1f);
            dicAnchor["anchorMax"] = new Vector2(1f, 1f);
            dicAnchor["buttonPos"] = new Vector2(-290, -120);
            c.createButtons("buttonShelfRight", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_shelf_right(); }),
             false, true);
        }

        private void createLampButton()
        {
            dicAnchor["anchorMin"] = new Vector2(1f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(1f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-275, -13);
            c.createButtons("buttonLamp", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { this.lis_roundtable(); }),
             false, true);
        }


        private void createBackButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0f, 0f);
            dicAnchor["anchorMax"] = new Vector2(0f, 0f);
            dicAnchor["buttonPos"] = new Vector2(100, 70);
            c.createButtons("buttonBack", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_back(); }),
              true, true);
        }

        private void lis_envelopeZoom()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().envelope();
            d.done = false;
            alreadyHere = false;

        }

        private void lis_fireplace()
        {
            destroyButtons();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().fireplace();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_table()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().wineTable();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_body()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().body();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_roundtable()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().roundTable();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_couch()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().couch();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_messfp()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().fpMess();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_wall()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().wallPics();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_shelf_left()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().shelfLeft();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_shelf_right()
        {
            destroyButtons();
            stopFireAnimation();
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().shelfRight();
            d.done = false;
            alreadyHere = false;
        }

        private void lis_back()
        {
            alreadyHere = true;
         //   GameObject tb = GameObject.FindGameObjectWithTag("canvas"); 
          //  tb.GetComponent<TextBox>().textBool = false;
            //GameObject bg = GameObject.FindGameObjectWithTag("bg");
            //bg.GetComponent<Background>().back();
            //d.done = false;

        }

	}
