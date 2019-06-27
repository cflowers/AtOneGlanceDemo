using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

	public class Misc
	{
        public void createNewPlaceHolders(string name, bool isLoad)
        {
           // Debug.Log("Create New Place Holders");
            GameObject panel = Resources.Load("Prefab/PlaceHolders1") as GameObject;

            if (isLoad)
                panel.tag = name;
            else
                panel.tag = createTag(name);

            GameObject bufPanel = GameObject.Instantiate(panel);
            GameObject mainPanel = GameObject.FindGameObjectWithTag("whatever");
            bufPanel.transform.SetParent(mainPanel.transform);
            bufPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            GameObject holder = Resources.Load("Prefab/holder") as GameObject;
            setUpPlaceHolders(bufPanel, holder, -90);
            setUpPlaceHolders(bufPanel, holder, -180);
            WhichPanel.Panel = bufPanel;
            PanelUtility p = new PanelUtility(name, bufPanel);
            //Debug.Log("PanelUtility:" + p);
            WhichPanel.getInstance().List.Add(p);
            //for(int i =0; i< WhichPanel.getInstance().List.size(); i++)
            //Debug.Log("WHICHPANEL FPART" + WhichPanel.getInstance().List.get(i));
            //WhichPanel.getInstance().StartChecking = true;
        }


        private void setUpPlaceHolders(GameObject bufPanel, GameObject holder, float y)
        {
            float next = 90;
            float current = -321.5f;

            for (int i = 0; i < 4; i++)
            {
                GameObject bufHolder = GameObject.Instantiate(holder);
                bufHolder.transform.SetParent(bufPanel.transform);
                bufHolder.GetComponent<RectTransform>().anchoredPosition = new Vector2(current, y);
                current = current + next;
            }
        }

        //utility
        public string createTag(string name)
        {
            string tag = null;
            if (name == "LISA HAWK")
                tag = "placeHolderLisa";
            else if (name == "BRANDON HAWK")
                tag = "placeHolderDad";
            else if (name == "STACY HAWK")
                tag = "placeHolderSis";
            else if (name == "FAREED")
                tag = "placeHolderFareed";

            return tag;
        }


        public void helperPlaceHolders(bool e, GameObject panel)
        {
            GameObject mainPH = panel;
            RawImage[] ri = mainPH.GetComponentsInChildren<RawImage>();
            Hover_Laptop[] h = mainPH.GetComponentsInChildren<Hover_Laptop>();
            Text[] t = mainPH.GetComponentsInChildren<Text>();
            Image[] img = mainPH.GetComponentsInChildren<Image>();
            Button[] button = mainPH.GetComponentsInChildren<Button>();
            for (int i = 0; i < ri.Length; i++)
            {

                ri[i].enabled = e;
                h[i].enabled = e;

                if (i < t.Length)
                {
                    t[i].enabled = e;
                    img[i].enabled = e;
                    button[i].enabled = e;
                }

            }
        }

        public void _ableButtons(bool e, GameObject panel)
        {
            GameObject mainPH = panel;
            Text[] t = mainPH.GetComponentsInChildren<Text>();
            Image[] img = mainPH.GetComponentsInChildren<Image>();
            Button[] button = mainPH.GetComponentsInChildren<Button>();

            for (int i = 0; i < button.Length; i++)
            {

                t[i].enabled = e;
                img[i].enabled = e;
                button[i].enabled = e;
            }
        }


        public void changeTextButtons(GameObject panel, string[] lines)
        {
            GameObject mainPH = panel;
            Text[] t = mainPH.GetComponentsInChildren<Text>();
            Image[] img = mainPH.GetComponentsInChildren<Image>();
            Button[] button = mainPH.GetComponentsInChildren<Button>();

            for (int i = 0; i < lines.Length; i++)
            {
                t[i].text = lines[i];
            }
        }


       public void disableAllPlaceHolders()
        {
            if (WhichPanel.Panel != null)
            {
                for (int a = 0; a < WhichPanel.getInstance().List.size(); a++)
                    helperPlaceHolders(false, WhichPanel.getInstance().List.get(a).Panel);
            }
        }

       public void enableAllPlaceHolders()
        {
            if (WhichPanel.Panel != null)
            {
                Debug.Log("List:" + WhichPanel.getInstance().List.size());
                //for (int a = 0; a < WhichPanel.List.size(); a++)
                helperPlaceHolders(true, WhichPanel.getInstance().List.get(0).Panel);
            }
        }

       public void _ableToggles(GameObject togglesGrp, bool able)
       {
          
           toggleOff(togglesGrp);
           Image[] images = togglesGrp.GetComponentsInChildren<Image>();
           Text[] t = togglesGrp.GetComponentsInChildren<Text>();
        
           for (int i = 0; i < images.Length; i++)
           {
             
               images[i].enabled = able;
               if (i < t.Length)
                   t[i].enabled =able;
           }
       }

       private void toggleOff(GameObject togglesGrp){
        Toggle[] toggles = togglesGrp.GetComponentsInChildren<Toggle>();
          Debug.Log(toggles[0].graphic.color);
          
            for (int i = 0; i < toggles.Length; i++)
           {
               toggles[i].graphic.color = new Color(1,1,1,0);
             //  toggles[i].graphic.canvasRenderer.SetAlpha(0);
               toggles[i].isOn = false;
           }
       }






	}

