using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

/**
 * This is used for loading the needed information
 * when a user is entering the laptop scene
 */
public class LapTopLoadHelper
{
    Misc misc = new Misc();
    FillPanelMap map = new FillPanelMap();
    List<string> keys;
    Dictionary<string, SuspectGameObject> bufferMap = new Dictionary<string, SuspectGameObject>();

    public void load(bool first)
    {
        //if this is not a new game and this method
        //never been called load information
        Debug.Log("New Game:" + LapTopInfo.Dat.NewGame);
          Debug.Log("New Game2:" + first);
        if (!LapTopInfo.Dat.NewGame || first)
        {
          try{
            Debug.Log("Loading Information for Suspects");
            map.fillPanelMap();
             this.bufferMap = map.Map;
            //keys = new List<string>(this.bufferMap.Keys);
            loadButtons();
            loadInputInfo();
            loadPanels();
          }
          catch(NullReferenceException nre){
            loadButtons();
            loadInputInfo();
          }
          catch(ArgumentException ae){
            loadButtons();
            loadInputInfo();
            loadPanels();

          }
        }
    }


    /**
     * check NameList in saved data file
     * if name is in data file enable 
     * specified button on the suspect screen
     * 
     */
    void loadButtons()
    {
        CFLinkedList<string> list = LapTopInfo.Dat.NameList;
        Debug.Log("Load Buttons method, size of list:" + list.size());
        for (int i = 0; i < list.size(); i++)
             setBtns(list, i);
    }

    void loadInputInfo()
    {
        GameObject recSuspect = Scene2_GettingObjs.getObjs().RecSuspect;
       // recSuspect.GetComponent<InputInfo>().this.bufferMap = LapTopInfo.Dat.Map;
       this.bufferMap = LapTopInfo.Dat.Map;
    }

    void loadPanels()
    {
        noData();
        loadData();
    }

    void setBtns(CFLinkedList<string> list, int i)
    {
        keys = new List<string>(this.bufferMap.Keys);
        foreach (string key in keys)
        {
            if (list.get(i) == key)
            {
                GameObject.FindGameObjectWithTag(this.bufferMap[key].getBtnName()).GetComponent<Image>().enabled = true;
                GameObject.FindGameObjectWithTag(this.bufferMap[key].getBtnName()).GetComponent<Button>().interactable = true;
            }
        }
    }

    void noData()
    {
        if (LapTopInfo.Dat.Notes.size() == 0)
        {
            Debug.Log("No Notes Found");
            noDataPlaceHolders();
        }
    }

    void loadData()
    {
        for (int i = 0; i < LapTopInfo.Dat.NameList.size(); i++)
        {
         //   Debug.Log("Loading...");
            loadNotes(LapTopInfo.Dat.NameList.get(i));

        }
    }


    void noDataPlaceHolders()
    {
        //loop through map and create new place holders accordingly
          foreach (string key in keys)
            misc.createNewPlaceHolders(LapTopInfo.Dat.Map[key].getPanelName(), true);
    }

    void loadNotes(string name)
    {
        CFLinkedList<LoadNotesSave> notes = new CFLinkedList<LoadNotesSave>();
        Debug.Log("Name:" + name);
        notes = getNotes(name); //look for notes for the specified name 
        int start = 0;
        int end = 8;
        int noteSize = notes.size();//size of the list of notes that was retrieved based on the name
        double panelSize = (double)notes.size() / 8;//obtain whole number
        long iPart = (long)panelSize;
        double fPart = panelSize - iPart;//obtain fraction
        Debug.Log("How Many Notes for " + name + ":" + noteSize);
        //Debug.Log("Whole Num:" + iPart);
        //Debug.Log("FPart:" + fPart);
        //Debug.Log("LoadList:" + LapTopInfo.Dat.Notes.size());
        wholeLoadItems(name, iPart, start, end, fPart, noteSize,notes);
        enableAllPlaceHolders();
        disableAllPlaceHolders();
    }

 
    /**
     * Business rule:
     * Only allow 8 images to be shown at a time
     * when loading if there is 8 use this method
     * if there is more than 8 use this method on the 8
     * and the remianderLoadItems on the rest
     */ 
    void wholeLoadItems(string name, long iPart, int start, int end, double fPart, int noteSize,CFLinkedList<LoadNotesSave> notes)
    {
        for (int a = 0; a < iPart; a++)
        {
            misc.createNewPlaceHolders(name, false);
            RawImage[] holders = WhichPanel.Panel.GetComponentsInChildren<RawImage>();
            makeLoadItems(start, end, holders, notes, true, 0);
            start = start + 8;
            end = end + 8;
        }

        remainderLoadItems(name, fPart, start, noteSize, notes);
    }

    void remainderLoadItems(string name, double fPart, int start, int noteSize,CFLinkedList<LoadNotesSave> notes)
    {
        if (fPart > 0)
        {
            misc.createNewPlaceHolders(name, false);
            int holderIndex = 0;
            RawImage[] holders = WhichPanel.Panel.GetComponentsInChildren<RawImage>();
            makeLoadItems(start, noteSize, holders, notes, false, holderIndex);
        }
    }

    CFLinkedList<LoadNotesSave> getNotes(string name)
    {
        CFLinkedList<LoadNotesSave> resultList = new CFLinkedList<LoadNotesSave>();
        foreach (string key in keys)
        {
            if (key == name)
            {
                Debug.Log("The key is " + key + " and the name is " + name);
                Debug.Log("Therefore the panel name is " + this.bufferMap[key].getPanelName());
                resultList = findNotesName(this.bufferMap[key].getPanelName());
                break;
            }
        }
        return resultList;
    }

    /**
    * loop through notes to find the specified tag
    * and add it to resultList
    */
    CFLinkedList<LoadNotesSave> findNotesName(string tag)
    {
     
        CFLinkedList<LoadNotesSave> resultList = new CFLinkedList<LoadNotesSave>();
        Debug.Log("The size of the notes that are on file is:" + LapTopInfo.Dat.Notes.size());
        for (int i = 0; i < LapTopInfo.Dat.Notes.size(); i++)
        {
            if (LapTopInfo.Dat.Notes.get(i).Panel == tag)
            {
                //Debug.Log("Finding Notes:" + LapTopInfo.Dat.Notes.get(i).Panel);
                resultList.Add(LapTopInfo.Dat.Notes.get(i));
            }
        }
       // Debug.Log("Tag:" + tag + "," + resultList.size());
        return resultList;
    }

    string obtainName(string tag)
    {
        string name = null;
        foreach (string key in keys)
        {
            if (this.bufferMap[key].getPanelName() == tag)
            {
                name = key;
                break;
            }
        }
        return name;
    }

    void disableAllPlaceHolders()
    {
        if (WhichPanel.Panel != null)
        {
            for (int a = 1; a < WhichPanel.getInstance().List.size(); a++)
                misc.helperPlaceHolders(false, WhichPanel.getInstance().List.get(a).Panel);
        }
    }

    void enableAllPlaceHolders()
    {
        if (WhichPanel.Panel != null)
        {
            Debug.Log("List of total placeholders:" + WhichPanel.getInstance().List.size());
            //for (int a = 0; a < WhichPanel.List.size(); a++)
            misc.helperPlaceHolders(true, WhichPanel.getInstance().List.get(0).Panel);
        }
    }

    void makeLoadItems(int start, int end, RawImage[] holders, CFLinkedList<LoadNotesSave> notes,
        bool isWholePart, int holderIndex)
    {

        for (int i = start; i < end; i++)
        {
            ItemsFactory item = notes.get(i).Item;
            item.beginText();
            item.loadImage();
            GameObject imgObj = Resources.Load("Prefab/CloseBtn") as GameObject;
            GameObject go = GameObject.Instantiate(imgObj);

            if (isWholePart)
            {
                holders[i].texture = item.getPic();
                float x = holders[i].transform.position.x + go.GetComponent<RectTransform>().rect.width;
                float y = holders[i].transform.position.y + go.GetComponent<RectTransform>().rect.height;
                go.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, 0);
                go.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
                go.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
                go.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
                go.transform.SetParent(holders[i].transform);
            }

            else
            {
                holders[holderIndex].texture = item.getPic();
                float x = holders[holderIndex].transform.position.x + go.GetComponent<RectTransform>().rect.width;
                float y = holders[holderIndex].transform.position.y + go.GetComponent<RectTransform>().rect.height;
                go.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, 0);
                go.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
                go.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
                go.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
                go.transform.SetParent(holders[holderIndex].transform);
                holderIndex++;
            }

            go.GetComponent<Button>().onClick.AddListener(delegate { lis_delete(go.transform, item); });
        }
    }

    void lis_delete(Transform transform, ItemsFactory item)
    {
        Texture2D texWhite = Resources.Load("textures/tex_white") as Texture2D;
        RawImage holder = transform.parent.gameObject.GetComponent<RawImage>();
        GameObject.Destroy(transform.gameObject);
        holder.texture = texWhite;
        for (int i = 0; i < LapTopInfo.ListSaveNotes.size(); i++)
        {
            if (LapTopInfo.ListSaveNotes.get(i).Item == item)
                LapTopInfo.ListSaveNotes.RemoveObj(LapTopInfo.ListSaveNotes.get(i));
        }
    }




}

