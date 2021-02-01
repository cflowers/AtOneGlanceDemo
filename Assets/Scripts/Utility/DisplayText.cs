using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


	public class DisplayText : MonoBehaviour
	{
        public bool readLine = false;
        public ItemsFactory item;
        public Text panelText;
        public Canvas popUp;
        Canvas phonePopUp;
        public Canvas canvas;

       
        int cur = 0;
        int end = 0;

        void Start()
        {
            this.phonePopUp = Scene_GettingObjs.getObjs().PhonePopUp.GetComponent<Canvas>();
        }

       public void ReadTextListener()
        {
            if (readLine)
            {
            
                    readTextFile(panelText, item.getText());

            }

        }

        void readTextFile(Text contents, string[] lines)
        {
        
            end = lines.Length;
            if (cur < end)
            {
                contents.text = lines[cur];
                cur++;
            }

            else
            {
                contents.text = "";
                readLine = false;
                cur = 0;
                popUpNow();
              
            }
        }

        public void popUpNow()
        {
            popUp.enabled = true;
            popUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            popUp.GetComponent<PopUp>().setItem(item);
            popUp.GetComponent<PopUp>().setShow(true);
        }

        public void popUpPhone()
        {
            phonePopUp.enabled = true;
            phonePopUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().setShowPhone(true);
        }

        public void popUpPhone2()
        {
            phonePopUp.GetComponent<Canvas>().enabled = true;
            phonePopUp.GetComponent<Canvas>().sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().setShowPhone2(true);
        }

        public void popUpPhoneStacy1()
        {
            phonePopUp.enabled = true;
            phonePopUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().StacyPhone = true;
        }

        public void popUpPhoneStacy2()
        {
            phonePopUp.enabled = true;
            phonePopUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().StacyPhone2 = true;
        }

        public void popUpPhoneFareed1()
        {
            phonePopUp.enabled = true;
            phonePopUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().FareedPhone = true;
        }

        public void popUpPhoneFareed2()
        {
            phonePopUp.enabled = true;
            phonePopUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().FareedPhone2 = true;
        }

        public void popUpPhoneFareed3()
        {
            phonePopUp.enabled = true;
            phonePopUp.sortingOrder = 1;
            TimerSC.getTimer().IsTicking = true;
            phonePopUp.GetComponent<PopUp>().setItem(item);
            phonePopUp.GetComponent<PopUp>().FareedPhone3 = true;
        }
	}

