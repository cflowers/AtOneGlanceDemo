using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

	public class PhoneCompositor
	{
        LinkedList<GameObject> list = new LinkedList<GameObject>();
        Dictionary<string, Vector2> dicAnchor = new Dictionary<string, Vector2>();
        CreateButton c;
        GameObject hud_points;
        Done d;
        string last;

        public PhoneCompositor(CreateButton c, GameObject hud_points,Done d, string last)
        {
            this.c = c;
            this.hud_points = hud_points;
            this.d= d;
            this.setUpDic();
            this.last = last;
        }

        private Dictionary<string, Vector2> setUpDic()
        {
            dicAnchor.Add("anchorMin", new Vector2(0.5f, 0f));
            dicAnchor.Add("anchorMax", new Vector2(0.5f, 0f));
            dicAnchor.Add("pivot", new Vector2(0.5f, 0.5f));
            dicAnchor.Add("buttonPos", new Vector2(0, 0));

            return dicAnchor;
        }
       
        public void createPhoneWriteButton()
        {
            dicAnchor["anchorMin"] = new Vector2(1f, 1f);
            dicAnchor["anchorMax"] = new Vector2(1f, 1f);
            dicAnchor["buttonPos"] = new Vector2(-120, -90);
            c.createWriteButton(c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_write(); }));
        }

        public void createPhoneDontWriteButton()
        {
            dicAnchor["anchorMin"] = new Vector2(1f, 0.5f);
            dicAnchor["anchorMax"] = new Vector2(1f, 0.5f);
            dicAnchor["buttonPos"] = new Vector2(-116f, 83.5f);
            c.createDontWriteButton(c.getCanvas().GetComponent<Canvas>().transform, dicAnchor, new UnityAction(delegate { lis_dontWrite(); }));
        }

        private void lis_write()
        {
            bool write = c.getCanvas().GetComponent<PopUp>().getItem().getWrite();
            Hud anim = c.getCanvas().GetComponent<Hud>();
            if (write)
                helper_lisWrite(anim, 2);
            else if (!write)
                helper_lisWrite(anim, -5);

        }

        private void lis_dontWrite()
        {
            bool write = c.getCanvas().GetComponent<PopUp>().getItem().getWrite();
            if (write)
                helper_lisDontWrite(-5);
            else if (!write)
                helper_lisDontWrite(2);
        }


        private void helper_lisWrite(Hud anim, int howMany)
        {
            falsifyDadPopUps();
            falsifyStacyPopUps();
            falsifyFareedPopUps();
            lis_back();
            c.getCanvas().GetComponent<Canvas>().sortingOrder = -1;//hide popup
            NotebookInfo.getNotebook().AddItem(c.getCanvas().GetComponent<PopUp>().getItem());//save item to notebook
            updatePoints(howMany);
            animatePics(anim);
            resetTimer();
           
        }

        private void helper_lisDontWrite(int howMany)
        {
            falsifyDadPopUps();
            falsifyStacyPopUps();
            falsifyFareedPopUps();
            lis_back();
            c.getCanvas().GetComponent<Canvas>().sortingOrder = -1;//hide popup
            updatePoints(howMany);
            resetTimer();
        }

        private void updatePoints(int howMany)
        {
            int points = PlayerInfo.Points;
            PlayerInfo.Points = points + howMany;
            hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
        }

        private void animatePics(Hud anim)
        {
            anim.buttonPressed = true;
            anim.canvas = c.getCanvas().GetComponent<Canvas>();
            anim.pic.texture = c.getCanvas().GetComponent<PopUp>().getItem().getPic();
        }

        private void resetTimer()
        {
            TimerSC.getTimer().ResetTimer();
            TimerSC.getTimer().IsTicking = false;
        }

        private void lis_back()
        {
            destroyButtons();
            GameObject img = GameObject.FindGameObjectWithTag(last);
            img.GetComponent<RawImage>().enabled = false;
            GameObject bg = GameObject.FindGameObjectWithTag("canvas");
            bg.GetComponent<Background>().back();
            d.done = false;

        }

        private void destroyButtons()
        {
            if (c.getButtons().Count > 0)
            {
                int size = c.getButtons().Count;

                for (int i = 0; i < size; i++)
                {
                    GameObject.Destroy(c.getButtons().First.Value);
                    c.getButtons().RemoveFirst();
                }
            }
        }

        private void falsifyDadPopUps()
        {
            if (last.Equals("dadMess1Zm"))
            {
                Debug.Log("DADMess1ZM");
                c.getCanvas().GetComponent<PopUp>().setShowPhone(false);
            }
            else if (last.Equals("dadMess2Zm"))
            {
                Debug.Log("DADMess2ZM");
                c.getCanvas().GetComponent<PopUp>().setShowPhone2(false);
            }

        }

        private void falsifyStacyPopUps()
        {
            if (last.Equals("stacyMess1Zm"))
            {
                Debug.Log("StacyMess1ZM");
                c.getCanvas().GetComponent<PopUp>().StacyPhone = false;
            }
            else if (last.Equals("stacyMess2Zm"))
            {
                Debug.Log("StacyMess2ZM");
                c.getCanvas().GetComponent<PopUp>().StacyPhone2 = false;
            }

        }

        private void falsifyFareedPopUps()
        {
            if (last.Equals("fareedMess1Zm"))
            {
                Debug.Log("FareedMess1ZM");
                c.getCanvas().GetComponent<PopUp>().FareedPhone = false;
            }
            else if (last.Equals("fareedMess2Zm"))
            {
                Debug.Log("FareedMess2ZM");
                c.getCanvas().GetComponent<PopUp>().FareedPhone2 = false;
            }

            else if (last.Equals("fareedMess3Zm"))
            {
                Debug.Log("FareedMess3ZM");
                c.getCanvas().GetComponent<PopUp>().FareedPhone3 = false;
            }

        }

}

