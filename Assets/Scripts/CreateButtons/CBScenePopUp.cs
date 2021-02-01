using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

	public class CBScenePopUp: AbstractCBScene{

        Done d;
        Done d2;
        GameObject hud_points;
        GameObject panel;
        GameObject tb;

        public override void placing(Done d, Done d2, bool sceneBool)
        {
            this.d = d;
            this.d2 = d2;
            if(!(d2.done) && sceneBool)
              getScenePopUpButtons();
        }

        private void getScenePopUpButtons()
        {
            c.setCanvas("popup");
            d2.done = true;
            panel = Scene_GettingObjs.getObjs().PopUp;
            tb = Scene_GettingObjs.getObjs().Canvas;
            hud_points = GameObject.FindGameObjectWithTag("points");
            createWriteButton();
            createDontWriteButton();
            base.setButtons(c.getButtons());
        }

        private void checkTime()
        {
            if (TimerSC.getTimer().RemainingSeconds == 0)
            {
            }
        }

        private void createWriteButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-185, -267);
            c.createWriteButton(panel.transform,dicAnchor, new UnityAction(delegate { lis_write(); }));
        }

        private void createDontWriteButton()
        {
            dicAnchor["anchorMin"] = new Vector2(0.5f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(0.5f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(236, -266);
            c.createDontWriteButton(panel.transform, dicAnchor, new UnityAction(delegate { lis_dontWrite(); }));
        }

        private void lis_write()
        {
            bool write = c.getCanvas().GetComponent<PopUp>().getItem().getWrite();
            Hud anim = c.getCanvas().GetComponent<Hud>();
            if (write)
            {
                helper_lisWrite(anim, 0);
            }

            else if (!write)
            {
                helper_lisWrite(anim, 0);
            }

        }

        private void lis_dontWrite()
        {
            bool write = c.getCanvas().GetComponent<PopUp>().getItem().getWrite();
            if (write)
            {
                helper_lisDontWrite(-10);
            }

            else if (!write)
            {
                helper_lisDontWrite(5);
            }
        }


        private void helper_lisWrite(Hud anim, int howMany)
        {
            
            destroyButtons();
            c.getCanvas().GetComponent<Canvas>().sortingOrder = -1;
           // updatePoints(howMany);
            anim.buttonPressed = true;
            anim.canvas = c.getCanvas().GetComponent<Canvas>();
            anim.pic.texture =c.getCanvas().GetComponent<PopUp>().getItem().getPic();
            tb.GetComponent<TextBox>().textBool = false;
            TimerSC.getTimer().ResetTimer();
            TimerSC.getTimer().IsTicking = false;
            //NotebookInfo.getNotebook().AddItem(c.getCanvas().GetComponent<PopUp>().getItem());
            Scene_GettingObjs.getObjs().Canvas.GetComponent<Background>().back();
            d.done = false;
            d2.done = false;
            Scene_GettingObjs.getObjs().PopUp.GetComponent<PopUp>().setShow(false);
            Misc misc = new Misc();
            //enable toggles
            misc._ableToggles(Scene_GettingObjs.getObjs().NotebookToggle, true);
            //open notebook
            Scene_GettingObjs.getObjs().Notebook.GetComponent<Canvas>().enabled = true;
            //disables next and back page buttons
            misc._ableButtons(false, GameObject.FindGameObjectWithTag("turn"));
             misc._ableButtons(false, GameObject.FindGameObjectWithTag("turn_back"));
              AudioSource audio;
                 AudioClip lostItem = Resources.Load<AudioClip>("Audio/SFX/points");
                 GameObject sfx = GameObject.FindGameObjectWithTag("sfx");
                 audio = sfx.GetComponent<AudioSource>();
                audio.clip = lostItem;
                  audio.Play();
           
        }

        private void helper_lisDontWrite(int howMany)
        {
            destroyButtons();
            c.getCanvas().GetComponent<Canvas>().sortingOrder = -1;
            updatePoints(howMany);
            tb.GetComponent<TextBox>().textBool = false;
            TimerSC.getTimer().ResetTimer();
            TimerSC.getTimer().IsTicking = false;
            Scene_GettingObjs.getObjs().Canvas.GetComponent<Background>().back();
            d.done = false;
            d2.done = false;
            Scene_GettingObjs.getObjs().PopUp.GetComponent<PopUp>().setShow(false);
            AudioSource audio;
                 AudioClip lostItem = Resources.Load<AudioClip>("Audio/SFX/points");
                 GameObject sfx = GameObject.FindGameObjectWithTag("sfx");
                 audio = sfx.GetComponent<AudioSource>();
                audio.clip = lostItem;
                  audio.Play();
        }

        private void updatePoints(int howMany)
        {
            int points = PlayerInfo.Points;
            PlayerInfo.Points = points + howMany;
            hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
            if(points <=0){
                   GameObject.FindGameObjectWithTag("verdict").GetComponent<Canvas>().sortingOrder = 1;
                GameObject.FindGameObjectWithTag("verdict").GetComponentInChildren<Text>().text = "You Lost";
            }
        }


}
