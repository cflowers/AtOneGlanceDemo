using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class LapTopInfo: MonoBehaviour {

    static LapTopInfo m_instance;
    static LapTopData dat = new LapTopData();
    static CFLinkedList<LoadNotesSave> listSaveNotes = new CFLinkedList<LoadNotesSave>();
    static CFLinkedList<string> enabledButtons = new CFLinkedList<string>();


    void Awake()
    {
        assignInstance();
    }

    void assignInstance()
    {
        if (m_instance != null && m_instance != this)
            Destroy(this);
        else
            m_instance = this;
    }

    public static LapTopInfo getLapTop()
    {
        return m_instance;
    }

    public static CFLinkedList<LoadNotesSave> ListSaveNotes
    {
        get { return LapTopInfo.listSaveNotes; }
        set { LapTopInfo.listSaveNotes = value; }
    }

    public static LapTopData Dat
    {
        get { return LapTopInfo.dat; }
        set { LapTopInfo.dat = value; }
    }


    public static CFLinkedList<string> EnabledButtons
    {
        get { return LapTopInfo.enabledButtons; }
        set { LapTopInfo.enabledButtons = value; }
    }
}
