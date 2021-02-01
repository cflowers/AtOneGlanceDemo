using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

/**
 * Information pertaining to the player like:
 * what level they are on
 * the points they have
 * how many lives they have
 * the name they are saved by
 */ 
public class PlayerInfo: MonoBehaviour {

    private static PlayerInfo m_instance;
    private static int points = 70;
    private static bool newGame = true;
    private static string name = null;

    private static int badges = 5;

    void Awake()
    {
        assignInstance();   
    }

    public void assignInstance()
    {
        if (m_instance != null && m_instance != this)
            Destroy(this);
        else
            m_instance = this;
    }
    
    public static PlayerInfo getPlayer()
    {
        return m_instance;
    }

    public static string Name
    {
        get { return PlayerInfo.name; }
        set { PlayerInfo.name = value; }
    }

    public static int Points
    {
        get { return PlayerInfo.points; }
        set { PlayerInfo.points = value; }
    }


    public static bool NewGame
    {
        get { return PlayerInfo.newGame; }
        set { PlayerInfo.newGame = value; }
    }

    public static int Badges { get => badges; set => badges = value; }
}
