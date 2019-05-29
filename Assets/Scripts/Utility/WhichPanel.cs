using UnityEngine;
using System.Collections;
using UnityEngine.UI;
  
  public class WhichPanel : MonoBehaviour 
 {
   
     static WhichPanel m_instance;
     static GameObject panel;
     CFLinkedList<PanelUtility> list;
     static CFLinkedList<PanelUtility> specList;//this list will always be updated with the panels of the specified tag
     bool startChecking = false;

     void Awake()
     {
         //Debug.Log("Which Panel Awake");
         assignInstance();
         list = new CFLinkedList<PanelUtility>();
       //  specList = new CFLinkedList<PanelUtility>();
     }

     void assignInstance()
     {
         if (m_instance != null && m_instance != this)
             Destroy(this);
         else
             m_instance = this;
     }

     //Update is called once per frame
     void Update () 
     {
         /*
          * if boolean of startChecking is true
          * then obtain tag of panel
          * panel.tag
          * then check list for panel.tag
          * if element is equal to tag
          * add to specList
          */
         //if (startChecking)
         //{
         //    WhichPanel.SpecList = new CFLinkedList<PanelUtility>();
         //    for(int i = 0; i<WhichPanel.List.size(); i++){
         //        //Debug.Log("Element:" + WhichPanel.getInstance().List.get(i).Panel.tag);
         //        if (WhichPanel.Panel.tag ==
         //            WhichPanel.List.get(i).Panel.tag)
         //        {
                   
         //            WhichPanel.SpecList.Add(WhichPanel.List.get(i));
         //           // Debug.Log("Panel Tag:" + WhichPanel.getInstance().Panel.tag);
         //           // Debug.Log("Added:" + WhichPanel.getInstance().List.get(i).Panel.tag);
         //        }
         //    }

         //    startChecking = false;
         //}
        
     }
     
     // Use this Method to access your WhichPanel
     public static WhichPanel getInstance()
     {   
         return m_instance;
     }

     public bool StartChecking
     {
         get { return startChecking; }
         set { startChecking = value; }
     }

     public static CFLinkedList<PanelUtility> SpecList
     {
         get { return specList; }
         set { specList = value; }
     }


     public CFLinkedList<PanelUtility> List
     {
         get { return list; }
         set { list = value; }
     }

     public static GameObject Panel
     {
         get { return panel; }
         set { panel = value; }
     }      
     
  }
