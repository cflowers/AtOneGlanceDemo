using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


	public class ButtonsInteraction : MonoBehaviour
	{
        /*
         * Enable or Disable buttons according to
         * counts
         * 
         */
        GameObject next;
        GameObject prev;
        public bool onPage = false;
        string name = null;

       
        void Start()
        {
            next = GameObject.FindGameObjectWithTag("nextPanel");
            prev = GameObject.FindGameObjectWithTag("prevPanel");
         
        }

        void Update()
        {
            if (onPage)
            {
                ableButtonInteraction();
                disablePrevious();
               
            }
        }

        public void disablePrevious()
        {
            checkNames("LISA HAWK");
            checkNames("BRANDON HAWK");
            checkNames("STACY HAWK");
            checkNames("FAREED");
        }

        void checkNames(string param)
        {
            CFLinkedList<PanelUtility> list = new CFLinkedList<PanelUtility>();

            if (name == param)
            {
               // Debug.Log("Before loop:" + list.size());
                for (int i = 0; i < WhichPanel.getInstance().List.size(); i++)
                {
                    if (WhichPanel.getInstance().List.get(i).Name == name)
                        list.Add(WhichPanel.getInstance().List.get(i));
                }

//                Debug.Log("After loop:" + list.size());


                if (list.size() == 1 || (WhichPanel.Panel == WhichPanel.getInstance().List.getFirst().Panel))
                {
  //                  Debug.Log("Size1");
                    prev.GetComponent<Button>().interactable = false;
                }

                else
                {
   //                 Debug.Log("Size2");
                    prev.GetComponent<Button>().interactable = true;
                }
            }
                onPage = false;
            
        }

        public void ableButtonInteraction()
        {
           // if (WhichPanel.getInstance().Panel != null)
            //{
                int imageCount = 0;
                GameObject mainPH = WhichPanel.Panel;
                RawImage[] gos = mainPH.GetComponentsInChildren<RawImage>();

                for (int i = 0; i < gos.Length; i++)
                {
                    if (gos[i].tag == "donePic" || gos[i].texture != null)
                        imageCount = imageCount + 1;

                }

                if (imageCount != 8)
                {

                    next.GetComponent<Button>().interactable = false;
                }

                else if (imageCount == 8)
                {
                    next.GetComponent<Button>().interactable = true;
                }
            //}
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


      
	}

