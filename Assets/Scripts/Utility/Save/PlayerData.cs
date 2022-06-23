using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public string name = null;
    int points = 0;
    bool newGame = false;
    NoteBookData notebook = null;
    public ItemsFactory[] items = new ItemsFactory[10];
    public LinkedList<ItemsFactory> itemList = new LinkedList<ItemsFactory>();//use for count
    public bool envelopeInsp = false;
    public bool mapInsp = false;
    public bool letterInsp = false;
    public bool fppicLInsp = false;
    public bool fppicRInsp = false;
    public bool fpphone = false;
    public bool wineBottleInsp = false;
    public bool wineGlassFInsp = false;
    public bool wineGlassEInsp = false;
    public bool bodyInsp = false;
    public bool handInsp = false;
    public bool rtPaper1Insp = false;
    public bool rtPaper2Insp = false;
    public bool pbookcaseInsp = false;
    public bool bbookcaseInsp = false;
    public bool gbookcaseInsp = false;
    public bool couchBook = false;
    public bool couchCD = false;
    public bool log = false;
    public bool logHolder = false;
    public bool binder = false;
    public bool broom = false;
    public bool dadPic = false;
    public bool wallPic = false;
    public bool fork = false;
    public bool pick = false;
    public bool shovel = false;
    public bool boomBox = false;
    public bool clock = false;
    public bool tiger = false;
    public bool globe = false;
    public bool ticket = false;
    public bool stone = false;
    public bool cup = false;
    public bool jar = false;
    public bool award = false;
    public bool head = false;
    public bool statue = false;
    public bool dadMess1 = false;
    public bool dadMess2 = false;
    public bool stacyMess1 = false;
    public bool stacyMess2 = false;
    public bool fareedMess1 = false;
    public bool fareedMess2 = false;
    public bool fareedMess3 = false;
    public bool anthraxBook = false;
    public int badges = 0;


    public PlayerData()
    {
        notebook = new NoteBookData();
    }

    public void saveName()
    {
        name = PlayerInfo.Name;
    }

    public void saveItems()
    {
        items = notebook.items;
        itemList = notebook.itemList;
    }

    public void savePoints()
    {
        points = PlayerInfo.Points;
    }

      public void saveBadges()
    {
        badges = PlayerInfo.Badges;
    }

    public void saveInspection()
    {
        envelopeInsp = Inspection.getEnvelopeInsp();
        mapInsp = Inspection.getMapInsp();
        letterInsp = Inspection.getLetterInsp();
        fppicLInsp = Inspection.getFPPicLInsp();
        fppicRInsp = Inspection.getFPPicRInsp();
        fpphone = Inspection.getFPPhone();
        wineBottleInsp = Inspection.getWineBottleInsp();
        wineGlassFInsp = Inspection.getWineGlassFInsp();
        wineGlassEInsp = Inspection.getWineGlassEInsp();
        bodyInsp = Inspection.getBodyInsp();
        handInsp = Inspection.getHandInsp();
        rtPaper1Insp = Inspection.getRTPaper1Insp();
        rtPaper2Insp = Inspection.getRTPaper2Insp();
        pbookcaseInsp = Inspection.getPBookcaseInsp();
        bbookcaseInsp = Inspection.getBBookcaseInsp();
        gbookcaseInsp = Inspection.getGBookcaseInsp();
        couchBook = Inspection.getCouchBook();
        couchCD = Inspection.getCouchCD();
        log = Inspection.getLog();
        logHolder = Inspection.getLogHolder();
        binder = Inspection.getBinder();
        broom = Inspection.getBroom();
        dadPic = Inspection.getDadPic();
        wallPic = Inspection.getWallPic();
        fork = Inspection.getFork();
        pick = Inspection.getPick();
        shovel = Inspection.getShovel();
        boomBox = Inspection.getBoomBox();
        clock = Inspection.getClock();
        tiger = Inspection.getTiger();
        globe = Inspection.getGlobe();
        ticket = Inspection.getTicket();
        stone = Inspection.getStone();
        cup = Inspection.getCup();
        jar = Inspection.getJar();
        award = Inspection.getAward();
        head = Inspection.getHead();
        statue = Inspection.getStatue();
        dadMess1 = Inspection.getDadMess1();
        dadMess2 = Inspection.getDadMess2();
        stacyMess1 = Inspection.getStacyMess1();
        stacyMess2 = Inspection.getStacyMess2();
        fareedMess1 = Inspection.getFareedMess1();
        fareedMess2 = Inspection.getFareedMess2();
        fareedMess3 = Inspection.getFareedMess3();
        anthraxBook = Inspection.getAnthraxBook();

    }

    public void saveNewGame()
    {
        this.newGame = PlayerInfo.NewGame;
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public NoteBookData Notebook
    {
        get { return notebook; }
        set { notebook = value; }
    }


    public bool NewGame
    {
        get { return newGame; }
        set { newGame = value; }
    }

}

