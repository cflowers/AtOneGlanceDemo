using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class Inspection {
      
    static bool envelopeInsp = false;
    static bool gunInsp = false;
    static bool mapInsp = false;
    static bool letterInsp = false;
    static bool fppicLInsp = false;
    static bool fppicRInsp = false;
    static bool fpphone = false;
    static bool wineBottleInsp = false;
    static bool wineGlassFInsp = false;
    static bool wineGlassEInsp = false;
    static bool bodyInsp = false;
    static bool handInsp = false;
    static bool rtPaper1Insp = false;
    static bool rtPaper2Insp = false;
    static bool pbookcaseInsp = false;
    static bool bbookcaseInsp = false;
    static bool gbookcaseInsp = false;
    static bool couchBook = false;
    static bool couchCD = false;
    static bool log = false;
    static bool logHolder = false;
    static bool binder = false;
    static bool broom = false;
    static bool dadPic = false;
    static bool wallPic = false;
    static bool fork = false;
    static bool pick = false;
    static bool shovel = false;
    static bool boomBox = false;
    static bool clock = false;
    static bool tiger = false;
    static bool globe = false;
    static bool ticket = false;
    static bool stone = false;
    static bool cup = false;
    static bool jar = false;
    static bool award = false;
    static bool head = false;
    static bool statue = false;
    static bool dadMess1 = false;
    static bool dadMess2 = false;
    static bool stacyMess1 = false;
    static bool stacyMess2 = false;
    static bool fareedMess1 = false;
    static bool fareedMess2 = false;
    static bool fareedMess3 = false;
    static bool anthraxBook = false;
    static bool ticket2 = false;

   
    public static void setEnvelopeInsp(bool envelopeInsp)
    {
        
        Inspection.envelopeInsp = envelopeInsp;
    }

    public static bool getEnvelopeInsp()
    {
        return Inspection.envelopeInsp;
    }

    public static void setGunInsp(bool gunInsp)
    {

        Inspection.gunInsp = gunInsp;
    }

    public static bool getGunInsp()
    {
        return Inspection.gunInsp;
    }

    public static void setMapInsp(bool mapInsp)
    {
        Inspection.mapInsp = mapInsp;
    }

    public static bool getMapInsp()
    {
        return Inspection.mapInsp;
    }

    public static void setLetterInsp(bool letterInsp)
    {
        Inspection.letterInsp = letterInsp;
    }

    public static bool getLetterInsp()
    {
        return Inspection.letterInsp;
    }


    public static void setFPPicLInsp(bool fppicLInsp)
    {
        Inspection.fppicLInsp = fppicLInsp;
    }

    public static bool getFPPicLInsp()
    {
        return Inspection.fppicLInsp;
    }

    public static void setFPPicRInsp(bool fppicRInsp)
    {
        Inspection.fppicRInsp = fppicRInsp;
    }

    public static bool getFPPicRInsp()
    {
        return Inspection.fppicRInsp;
    }

    public static void setWineBottleInsp(bool wineBottleInsp)
    {
        Inspection.wineBottleInsp = wineBottleInsp;
    }

    public static bool getWineBottleInsp()
    {
        return Inspection.wineBottleInsp;
    }

    public static void setWineGlassFInsp(bool wineGlassFInsp)
    {
        Inspection.wineGlassFInsp = wineGlassFInsp;
    }

    public static bool getWineGlassFInsp()
    {
        return Inspection.wineGlassFInsp;
    }

    public static void setWineGlassEInsp(bool wineGlassEInsp)
    {
        Inspection.wineGlassEInsp = wineGlassEInsp;
    }

    public static bool getWineGlassEInsp()
    {
        return Inspection.wineGlassEInsp;
    }

    public static void setBodyInsp(bool bodyInsp)
    {
        Inspection.bodyInsp = bodyInsp;
    }

    public static bool getBodyInsp()
    {
        return Inspection.bodyInsp;
    }

    public static void setHandInsp(bool handInsp)
    {
        Inspection.handInsp = handInsp;
    }

    public static bool getHandInsp()
    {
        return Inspection.handInsp;
    }

    public static void setRTPaper1Insp(bool rtPaper1Insp)
    {
        Inspection.rtPaper1Insp = rtPaper1Insp;
    }

    public static bool getRTPaper1Insp()
    {
        return Inspection.rtPaper1Insp;
    }

    public static void setRTPaper2Insp(bool rtPaper2Insp)
    {
        Inspection.rtPaper2Insp = rtPaper2Insp;
    }

    public static bool getRTPaper2Insp()
    {
        return Inspection.rtPaper2Insp;
    }

    public static void setPBookcaseInsp(bool pbookcaseInsp)
    {
        Inspection.pbookcaseInsp = pbookcaseInsp;
    }

    public static bool getPBookcaseInsp()
    {
        return Inspection.pbookcaseInsp;
    }

    public static void setCouchCD(bool couchCD)
    {
        Inspection.couchCD = couchCD;
    }

    public static bool getCouchCD()
    {
        return Inspection.couchCD;
    }

    public static void setLog(bool log)
    {
        Inspection.log = log;
    }

    public static bool getLog()
    {
        return Inspection.log;
    }

    public static void setLogHolder(bool logHolder)
    {
        Inspection.logHolder = logHolder;
    }

    public static bool getLogHolder()
    {
        return Inspection.logHolder;
    }

    public static void setBinder(bool binder)
    {
        Inspection.binder = binder;
            
    }

    public static bool getBinder()
    {
        return Inspection.binder;
    }

    public static void setBroom(bool broom)
    {
        Inspection.broom = broom;

    }

    public static bool getBroom()
    {
        return Inspection.broom;
    }

    public static void setCouchBook(bool couchBook)
    {
        Inspection.couchBook = couchBook;

    }

    public static bool getCouchBook()
    {
        return Inspection.couchBook;
    }

    public static void setDadPic(bool dadPic)
    {
        Inspection.dadPic = dadPic;
    }

    public static bool getDadPic()
    {
        return Inspection.dadPic;
    }

    public static void setFork(bool fork)
    {
        Inspection.fork= fork;
    }

    public static bool getFork()
    {
        return Inspection.fork;
    }

    public static void setBoomBox(bool boomBox)
    {
        Inspection.boomBox = boomBox;
    }

    public static bool getBoomBox()
    {
        return Inspection.boomBox;
    }

    public static void setFPPhone(bool fpphone)
    {
        Inspection.fpphone = fpphone;
    }

    public static bool getFPPhone()
    {
        return Inspection.fpphone;
    }

    public static void setPick(bool pick)
    {
        Inspection.pick = pick;
    }

    public static bool getPick()
    {
        return Inspection.pick;
    }

    public static void setShovel(bool shovel)
    {
        Inspection.shovel = shovel;
    }

    public static bool getShovel()
    {
        return Inspection.shovel;
    }

    public static void setWallPic(bool wallPic)
    {
        Inspection.wallPic = wallPic;
    }

    public static bool getWallPic()
    {
        return Inspection.wallPic;
    }

    public static void setClock(bool clock)
    {
        Inspection.clock = clock;
    }

    public static bool getClock()
    {
        return Inspection.clock;
    }

    public static void setTiger(bool tiger)
    {
        Inspection.tiger = tiger;
    }

    public static bool getTiger()
    {
        return Inspection.tiger;
    }

    public static void setGlobe(bool globe)
    {
        Inspection.globe = globe;
    }

    public static bool getGlobe()
    {
        return Inspection.globe;
    }

    public static void setBBookcaseInsp(bool bbookcaseInsp)
    {
        Inspection.bbookcaseInsp = bbookcaseInsp;
    }

    public static bool getBBookcaseInsp()
    {
        return Inspection.bbookcaseInsp;
    }

    public static void setGBookcaseInsp(bool gbookcaseInsp)
    {
        Inspection.gbookcaseInsp = gbookcaseInsp;
    }

    public static bool getGBookcaseInsp()
    {
        return Inspection.gbookcaseInsp;
    }

    public static void setTicket(bool ticket)
    {
        Inspection.ticket = ticket;
    }

    public static bool getTicket()
    {
        return Inspection.ticket;
    }

     public static void setTicket2(bool ticket2)
    {
        Inspection.ticket2 = ticket2;
    }

    public static bool getTicket2()
    {
        return Inspection.ticket2;
    }


    public static void setStone(bool stone)
    {
        Inspection.stone = stone;
    }

    public static bool getStone()
    {
        return Inspection.stone;
    }

    public static void setCup(bool cup)
    {
        Inspection.cup = cup;
    }

    public static bool getCup()
    {
        return Inspection.cup;
    }

    public static void setJar(bool jar)
    {
        Inspection.jar = jar;
    }

    public static bool getJar()
    {
        return Inspection.jar;
    }

    public static void setHead(bool head)
    {
        Inspection.head = head;
    }

    public static bool getHead()
    {
        return Inspection.head;
    }

    public static void setAward(bool award)
    {
        Inspection.award = award;
    }

    public static bool getAward()
    {
        return Inspection.award;
    }

    public static void setStatue(bool statue)
    {
        Inspection.statue = statue;
    }

    public static bool getStatue()
    {
        return Inspection.statue;
    }

    public static void setDadMess1(bool dadMess1)
    {
        Inspection.dadMess1 = dadMess1;
    }

    public static bool getDadMess1()
    {
        return Inspection.dadMess1;
    }


    public static void setDadMess2(bool dadMess2)
    {
        Inspection.dadMess2 = dadMess2;
    }

    public static bool getDadMess2()
    {
        return Inspection.dadMess2;
    }

    public static void setStacyMess1(bool stacyMess1)
    {
        Inspection.stacyMess1 = stacyMess1;
    }

    public static bool getStacyMess1()
    {
        return Inspection.stacyMess1;
    }


    public static void setStacyMess2(bool stacyMess2)
    {
        Inspection.stacyMess2 = stacyMess2;
    }

    public static bool getStacyMess2()
    {
        return Inspection.stacyMess2;
    }

    public static void setFareedMess1(bool fareedMess1)
    {
        Inspection.fareedMess1 = fareedMess1;
    }

    public static bool getFareedMess1()
    {
        return Inspection.fareedMess1;
    }

    public static void setFareedMess2(bool fareedMess2)
    {
        Inspection.fareedMess2 = fareedMess2;
    }

    public static bool getFareedMess2()
    {
        return Inspection.fareedMess2;
    }

    public static void setFareedMess3(bool fareedMess3)
    {
        Inspection.fareedMess3 = fareedMess3;
    }

    public static bool getFareedMess3()
    {
        return Inspection.fareedMess3;
    }


    public static void setAnthraxBook(bool anthraxBook)
    {
        Inspection.anthraxBook = anthraxBook;
    }

    public static bool getAnthraxBook()
    {
        return Inspection.anthraxBook;
    }
}

