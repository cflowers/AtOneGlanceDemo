using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class LoadInfo {


       public void loadPlayerInfo(PlayerData playerDat){
            PlayerInfo.Points = playerDat.Points;
            PlayerInfo.NewGame = playerDat.NewGame;
            GameObject hud_points = Scene_GettingObjs.getObjs().Hud_points;
            hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
            Debug.Log("TIRED OF THIS;");
            loadPlayerData(playerDat);
            loadInspections(playerDat);
        }

       void loadPlayerData(PlayerData playerDat)
       {
           for (int i = 0; i < playerDat.itemList.Count; i++)
           {
               playerDat.items[i].beginText();
               playerDat.items[i].loadImage();
               NotebookInfo.getNotebook().AddItem(playerDat.items[i]);
               Debug.Log(NotebookInfo.getNotebook().getArr()[i]);
           }
       }

       void loadInspections(PlayerData playerDat)
       {
           Inspection.setEnvelopeInsp(playerDat.envelopeInsp);
           Inspection.setAnthraxBook(playerDat.anthraxBook);
           Inspection.setAward(playerDat.award);
           Inspection.setBBookcaseInsp(playerDat.bbookcaseInsp);
           Inspection.setBinder(playerDat.binder);
           Inspection.setBodyInsp(playerDat.bodyInsp);
           Inspection.setBoomBox(playerDat.boomBox);
           Inspection.setBroom(playerDat.broom);
           Inspection.setClock(playerDat.clock);
           Inspection.setCouchBook(playerDat.couchBook);
           Inspection.setCouchCD(playerDat.couchCD);
           Inspection.setCup(playerDat.cup);
           Inspection.setDadMess1(playerDat.dadMess1);
           Inspection.setDadMess2(playerDat.dadMess2);
           Inspection.setDadPic(playerDat.dadPic);
           Inspection.setFareedMess1(playerDat.fareedMess1);
           Inspection.setFareedMess2(playerDat.fareedMess2);
           Inspection.setFareedMess3(playerDat.fareedMess3);
           Inspection.setFork(playerDat.fork);
           Inspection.setFPPhone(playerDat.fpphone);
           Inspection.setFPPicLInsp(playerDat.fppicLInsp);
           Inspection.setFPPicRInsp(playerDat.fppicRInsp);
           Inspection.setGBookcaseInsp(playerDat.gbookcaseInsp);
           Inspection.setGlobe(playerDat.globe);
           Inspection.setHandInsp(playerDat.handInsp);
           Inspection.setHead(playerDat.head);
           Inspection.setJar(playerDat.jar);
           Inspection.setLetterInsp(playerDat.letterInsp);
           Inspection.setLog(playerDat.log);
           Inspection.setLogHolder(playerDat.logHolder);
           Inspection.setMapInsp(playerDat.mapInsp);
           Inspection.setPBookcaseInsp(playerDat.pbookcaseInsp);
           Inspection.setPick(playerDat.pick);
           Inspection.setRTPaper1Insp(playerDat.rtPaper1Insp);
           Inspection.setRTPaper2Insp(playerDat.rtPaper2Insp);
           Inspection.setShovel(playerDat.shovel);
           Inspection.setStacyMess1(playerDat.stacyMess1);
           Inspection.setStacyMess2(playerDat.stacyMess2);
           Inspection.setStatue(playerDat.statue);
           Inspection.setStone(playerDat.stone);
           Inspection.setTicket(playerDat.ticket);
           Inspection.setTiger(playerDat.tiger);
           Inspection.setWallPic(playerDat.wallPic);
           Inspection.setWineBottleInsp(playerDat.wineBottleInsp);
           Inspection.setWineGlassEInsp(playerDat.wineGlassEInsp);
           Inspection.setWineGlassFInsp(playerDat.wineGlassFInsp);
       }
}
