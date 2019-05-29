using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

	class JsonBuffer
	{
        public static string jsonString;
        public static JSONItem[] jsonItems;
        GameObject notebookToggle;
        Misc misc;

        void Start()
        {
          
        }
        public void setToggleText(string clue)
        {
            for (int i = 0; i < JsonBuffer.jsonItems.Length; i++)
            {
                if (JsonBuffer.jsonItems[i].item.Equals(clue))
                {
                    GameObject notebookToggle = GameObject.FindGameObjectWithTag("notebookToggle");
                    Text[] toggles = notebookToggle.GetComponentsInChildren<Text>();
                    toggles[0].text = JsonBuffer.jsonItems[i].first;
                    toggles[1].text = JsonBuffer.jsonItems[i].second;
                    toggles[2].text = JsonBuffer.jsonItems[i].third;
                    toggles[3].text = JsonBuffer.jsonItems[i].fourth;
                    
                    
                   // send toggle text to content 
                   // enable image
                   // disable write button
                }
            }
        }
	}

