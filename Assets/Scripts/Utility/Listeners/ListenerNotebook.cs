﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ListenerNotebook : MonoBehaviour
{

    int index = 0;
    Text notes;
    Vector3 origLocalPos;
    Vector3 origSizeDelta;
    bool origBestFit;
    int fontSize;
    RawImage noteImg;
    bool changed;
    Misc misc = new Misc();

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Level1")
        {
            notes = Scene_GettingObjs.getObjs().Notebook.GetComponentInChildren<Text>();
            origLocalPos = notes.rectTransform.localPosition;
            origSizeDelta = notes.rectTransform.sizeDelta;
            origBestFit = notes.resizeTextForBestFit;
            fontSize = notes.fontSize;
            noteImg = Scene_GettingObjs.getObjs().GetComponentInChildren<RawImage>();
            changed = false;
        }
    }


    //open notebook, start on the first page
    public void open_notebook()
    {
        Scene_GettingObjs.getObjs().Notebook.GetComponent<Canvas>().enabled = true;
        if (NotebookInfo.getNotebook().getFirstItemArr() != null)
        {
            notes.text = NotebookInfo.getNotebook().getFirstItemArr().getTextFile();
            noteImg.texture = NotebookInfo.getNotebook().getFirstItemArr().getPic();
        }
    }


    public void write()
    {
        //save item to NotebookInfo
        GameObject notebookText = GameObject.FindGameObjectWithTag("notebook_text");
        GameObject notebookToggle = Scene_GettingObjs.getObjs().NotebookToggle;
        Toggle[] toggles = notebookToggle.GetComponentsInChildren<Toggle>();
        foreach(Toggle toggle in toggles){
            if (toggle.isOn)
                notebookText.GetComponent<Text>().text = toggle.GetComponent<Text>().text;
        }
        Scene_GettingObjs.getObjs().Canvas.GetComponent<PopUp>().getItem().setItemDesc(notebookText.GetComponent<Text>().text);
        NotebookInfo.getNotebook().AddItem(Scene_GettingObjs.getObjs().Canvas.GetComponent<PopUp>().getItem());//save item to notebook
        //disable toggles
        misc._ableToggles(Scene_GettingObjs.getObjs().NotebookToggle,false);
                   
    }
    //close notebook
    public void close_notebook()
    {
        Scene_GettingObjs.getObjs().Notebook.GetComponent<Canvas>().enabled = false;
        index = 0;
    }


    //turn to the next page in notebook
    public void turn_foward()
    {
        if (index >= 0 && index < NotebookInfo.getNotebook().getList().Count - 1)
        {
            resetText();
            index++;
            if (index >= 0 && index < NotebookInfo.getNotebook().getList().Count)
            {
                resizeTextItems();
                notes.text = NotebookInfo.getNotebook().getArr()[index].getTextFile();
                noteImg.texture = NotebookInfo.getNotebook().getArr()[index].getPic();
            }
        }
    }

    //turn to previous page in notebook
    public void turn_back()
    {
        resetText();
        if (index > 0)
        {
            index--;
            if (index >= 0 && index < NotebookInfo.getNotebook().getList().Count)
            {
                resizeTextItems();
                notes.text = NotebookInfo.getNotebook().getArr()[index].getTextFile();
                noteImg.texture = NotebookInfo.getNotebook().getArr()[index].getPic();
            }
        }
    }

    private void resetText()
    {
        if (changed)
        {
            notes.resizeTextForBestFit = origBestFit;
            notes.rectTransform.localPosition = origLocalPos;
            notes.rectTransform.sizeDelta = origSizeDelta;
            changed = false;
        }
    }

    private void resizeTextItems()
    {
        if (NotebookInfo.getNotebook().getArr()[index].ToString() == "GoldPhoneItem")
        {
            resizeStacyMess1(notes);
            changed = true;
        }

        else if (NotebookInfo.getNotebook().getArr()[index].ToString() == "StacyItem2")
        {
            resizeStacyMess2(notes);
            changed = true;
        }

        else if (NotebookInfo.getNotebook().getArr()[index].ToString() == "DadItem1")
        {
            resizeDadMess1(notes);
            changed = true;
        }

        else if (NotebookInfo.getNotebook().getArr()[index].ToString() == "PurplePhoneItem1")
        {
            resizePurpleMess1(notes);
            changed = true;
        }

    }



    private void resizeStacyMess1(Text notes)
    {
        Debug.Log("Stacy Mess 1 Resize");
        notes.resizeTextForBestFit = true;
        notes.rectTransform.localPosition = new Vector3(29, 97, 0);
        notes.rectTransform.sizeDelta = new Vector2(386, 345);

    }

    private void resizeStacyMess2(Text notes)
    {
        Debug.Log("Stacy Mess 2 Resize");
        notes.resizeTextForBestFit = true;
        notes.rectTransform.localPosition = new Vector3(40, 93, 0);
        notes.rectTransform.sizeDelta = new Vector2(319, 358);

    }

    private void resizeDadMess1(Text notes)
    {
        Debug.Log("Dad Mess 1 Resize");
        notes.resizeTextForBestFit = true;
        notes.rectTransform.localPosition = new Vector3(51, 100, 0);
        notes.rectTransform.sizeDelta = new Vector2(286, 345);

    }

    private void resizePurpleMess1(Text notes)
    {
        Debug.Log("Purple Mess 1 Resize");
        notes.fontSize = 20;
        notes.rectTransform.localPosition = new Vector3(51, 100, 0);
        notes.rectTransform.sizeDelta = new Vector2(328, 354);

    }


}
