using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public class LapTopData
	{

        CFLinkedList<string> nameList = new CFLinkedList<string>();
        Dictionary<int, string> ansDic = new Dictionary<int, string>();
        CFLinkedList<LoadNotesSave> notes = new CFLinkedList<LoadNotesSave>();
        Dictionary<string, SuspectGameObject>  map = new Dictionary<string, SuspectGameObject>();
        bool newGame = true;

    public void saveSuspects()
    {
        GameObject suspects = GameObject.FindGameObjectWithTag("recSuspect1");
        map = suspects.GetComponent<InputInfo>().map.Map;
        nameList = suspects.GetComponent<InputInfo>().nameList;
        Debug.Log("SAVING SUSPECTS:" + nameList.size());
    }

    public void saveQuesAns()
    {
        GameObject quesAns = GameObject.FindGameObjectWithTag("screen");
        ansDic = quesAns.GetComponent<AnsFields>().ansDic;
    }

    public void saveNotes()
    {
        notes = LapTopInfo.ListSaveNotes;
        Debug.Log("Save how many notes to dat file:" + notes.size());
    }

    public bool NewGame
    {
        get { return newGame; }
        set { newGame = value; }
    }

    public CFLinkedList<LoadNotesSave> Notes
    {
        get { return notes; }
        set { notes = value; }
    }

    public Dictionary<int, string> AnsDic
    {
        get { return ansDic; }
        set { ansDic = value; }
    }

    public CFLinkedList<string> NameList
    {
        get { return nameList; }
        set { nameList = value; }
    }

    public Dictionary<string, SuspectGameObject> Map
    {
        get { return map; }
        set { map = value; }
    }

}

