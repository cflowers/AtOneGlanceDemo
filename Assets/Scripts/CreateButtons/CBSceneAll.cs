using System;
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
            dicAnchor["buttonPos"] = new Vector2(45, 24);
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
       
        }

        private void createFirePlaceButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-304, 40);
            c.createButtons("buttonFP", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_fireplace(); }),
              false, true);
        }

        private void createWineButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(45, -207);
             if (Inspection.getWineBottleInsp() == false || Inspection.getWineGlassEInsp()== false || Inspection.getWineGlassFInsp() == false)
            c.createButtons("buttonWG", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_table(); }),
             false, true);
            else if (Inspection.getWineBottleInsp() && Inspection.getWineGlassEInsp() && Inspection.getWineGlassFInsp())
            c.createButtons("buttonWG", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_table(); }),
             false, false);
        }


        private void createBodyButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-111, -263);
             if ((Inspection.getBodyInsp() == false) || Inspection.getHandInsp() == false || Inspection.getGunInsp() == false)
            c.createButtons("buttonBody", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_body(); }),
             false, true);
            else if (Inspection.getBodyInsp() && Inspection.getHandInsp() && Inspection.getGunInsp())
             c.createButtons("buttonBody", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_body(); }),
             false, false);
        }

        private void createCouchButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(162, -89);
            if ((Inspection.getCouchBook() == false) || Inspection.getCouchCD() == false)
            c.createButtons("buttonCouch", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_couch(); }),
             false, true);
            else  if (Inspection.getCouchBook() && Inspection.getCouchCD())
            c.createButtons("buttonCouch", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_couch(); }),
             false, false);
        }

        private void createFloorNearFPButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-109, -55);
            c.createButtons("buttonNearFP", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_messfp(); }),
             false, true);
        }

        private void createWallButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
            dicAnchor["buttonPos"] = new Vector2(-86, -240);
            c.createButtons("buttonWall", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_wall(); }),
             false, true);
        }

        private void createShelfLeftButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 1f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 1f);
            dicAnchor["buttonPos"] = new Vector2(146, -345);
            c.createButtons("buttonShelfLeft", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_shelf_left(); }),
             false, true);
        }

        private void createShelfRightButton()
        {
            dicAnchor["anchorMin"] = new Vector2(1f, 1f);
            dicAnchor["anchorMax"] = new Vector2(1f, 1f);
            dicAnchor["buttonPos"] = new Vector2(-263, -380);
            c.createButtons("buttonShelfRight", c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_shelf_right(); }),
             false, true);
        }

        private void createLampButton()
        {
            dicAnchor["anchorMin"] = new Vector2(1f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(1f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-266, -70);
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
        }

	}

