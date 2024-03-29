﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;


public class Hover_Laptop : EventTrigger
{


    LinkedList<GameObject> items;
    CFLinkedList<LoadNotesSave> listSaveNotes;
    GameObject buttonsInter;
    RawImage clueZmPic;
    Text clueZmDesc;
    Text clueZmTitle;
    bool nothingOccured = true;


    void Start()
    {
        GameObject gameObjects = GameObject.FindGameObjectWithTag("placementList");
        items = gameObjects.GetComponent<LaptopPlacementList>().getItems();
        listSaveNotes = gameObjects.GetComponent<LaptopPlacementList>().ListSaveNotes;
        buttonsInter = GameObject.FindGameObjectWithTag("nextPanel");
        clueZmPic = GameObject.FindGameObjectWithTag("clueZmPic").GetComponent<RawImage>();
        clueZmDesc = GameObject.FindGameObjectWithTag("clueZmDesc").GetComponent<Text>();
        clueZmTitle = GameObject.FindGameObjectWithTag("clueZmTitle").GetComponent<Text>();
      
    }

    // when highlighted with mouse.
    public override void OnPointerEnter(PointerEventData eventData)
    {
    }

    //when exiting the button
    public override void OnPointerExit(PointerEventData eventData)
    {
    }


    public override void OnPointerClick(PointerEventData eventData)
    {
        clickLeftButton(eventData);
        clickRightButton(eventData);
    }

    void clickLeftButton(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            helper_left(eventData);

        }
    }

    void clickRightButton(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            helper_right(eventData);
            GameObject screen = GameObject.FindGameObjectWithTag("clueZm");
            screen.GetComponent<Canvas>().enabled = true;
        }
    }

    void helper_left(PointerEventData eventData)
    {
     
        selectNote(eventData);
        selectPlacedNote(eventData);
        placeNote(eventData);
        destroy(eventData);
    }

    void helper_right(PointerEventData eventData)
    {
        checkTagTex(eventData);
    }

    /*
     * this starts when user selects the loaded notes at top of screen
     */ 
    void selectNote(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "picPh" && items.Count == 0)
        {
            GameObject copy = GameObject.Instantiate(eventData.pointerCurrentRaycast.gameObject);
            items.AddLast(copy);
            nothingOccured = false;
        }
    }

    void selectPlacedNote(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "donePic" && items.Count == 0)
        {
            items.AddLast(eventData.pointerCurrentRaycast.gameObject);
            nothingOccured = false;
        }
    }

    void replacePlacedNote(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "donePic" && items.Count == 1)
        {
            nothingOccured = false;
        }
    }

    void placeNote(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "node" && items.Count == 1)
        {
            items.AddLast(eventData.pointerCurrentRaycast.gameObject);
            items.First.Value.transform.position = items.Last.Value.transform.position;
            items.First.Value.transform.SetParent(items.Last.Value.transform);
            createCloseBtn();
            buttonsInter.GetComponent<ButtonsInteraction>().onPage = true;
            items.First.Value.tag = "donePic";
            destroyItems();
            nothingOccured = false;
        }
    }

    void errorPlacement(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "node" && items.Count == 0)
        {
            nothingOccured = false;
        }
    }

    void destroy(PointerEventData eventData)
    {
        if(nothingOccured && items.Count > 0)
        {
          GameObject.Destroy(items.First.Value);
          destroyItems();
        }

    }

    void createCloseBtn()
    {
        GameObject imgObj = Resources.Load("Prefab/CloseBtn") as GameObject;
        GameObject go = GameObject.Instantiate(imgObj);
        float x = items.First.Value.transform.position.x + go.GetComponent<RectTransform>().rect.width;
        float y = items.First.Value.transform.position.y + go.GetComponent<RectTransform>().rect.height;
        go.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, y, 0);
        go.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
        go.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        go.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        go.transform.SetParent(items.First.Value.transform);
        go.GetComponent<Button>().onClick.AddListener(delegate { lis_delete2(go); });
        addNoteToList(x, y);
    }

    void addNoteToList(float x, float y)
    {
        loopNotesForSaving(x, y);
        LapTopInfo.Dat.saveNotes();
    }

    void loopNotesForSaving(float x, float y)
    {
        for (int i = 0; i < NotebookInfo.getNotebook().getArr().Length; i++)
        {
            if(checkNotesName(i, x, y))
               break;
        }
    }

     bool checkNotesName(int i, float x, float y)
    {
        bool check = false;
        if (NotebookInfo.getNotebook().getArr()[i].getPic().name ==
                   items.First.Value.GetComponent<RawImage>().texture.name)
        {
            
            LoadNotesSave ls = new LoadNotesSave(WhichPanel.Panel.tag,
                NotebookInfo.getNotebook().getArr()[i], x, y);
            LapTopInfo.ListSaveNotes.Add(ls);
            check = true;
        }

        return check;
    }


    //is called when user does a right click
    void checkTagTex(PointerEventData eventData)
    {
        Texture tex = eventData.pointerCurrentRaycast.gameObject.GetComponent<RawImage>().texture;
        string tag = eventData.pointerCurrentRaycast.gameObject.tag;
        if (tag == "donePic" || (tag == "node" && tex != null) || (tag == "node" && tex != null && tex.name != "tex_white"))
            loopNoteBookInfo(tex);
    }

    //goes with checkTagTex method
    void loopNoteBookInfo(Texture tex)
    {  
        for (int i = 0; i < NotebookInfo.getNotebook().getList().Count; i++)
            setClueZmPicDesc(i, tex);
    }

    //goes with loopNoteBookInfo method
    void setClueZmPicDesc(int i, Texture tex)
    {
        
       if (NotebookInfo.getNotebook().getArr()[i].getPic().name == tex.name)
           {
             clueZmPic.texture = NotebookInfo.getNotebook().getArr()[i].getPic();
             clueZmDesc.text = NotebookInfo.getNotebook().getArr()[i].getItemDesc();
           } 
    }


    void lis_delete(Transform transform)
    {
        GameObject.Destroy(transform.parent.gameObject);
      

    }

     void lis_delete2(GameObject go)
    {
        removeNote(go.transform.parent.gameObject);
        GameObject.Destroy(go.transform.parent.gameObject);
    }

    void removeNote(GameObject go)
    {

        for (int i = 0; i < LapTopInfo.ListSaveNotes.size(); i++)
        {
            if (LapTopInfo.ListSaveNotes.get(i).Item.getPic() == go.GetComponentInChildren<RawImage>().texture)
            {
                LapTopInfo.ListSaveNotes.RemoveObj(LapTopInfo.ListSaveNotes.get(i));
                break;
            }
        }
    }

    void destroyItems()
    {
        if (items.Count > 0)
            items.Clear();
    }


}
