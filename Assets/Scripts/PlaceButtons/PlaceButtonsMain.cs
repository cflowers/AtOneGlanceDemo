using UnityEngine;
using System.Collections;

public class PlaceButtonsMain : MonoBehaviour {
    public Done d;
    public Done popUpD;
    Background bg;
    PopUp p;
    PopUp phone;
    CreateButtonCntl controller = new CreateButtonCntl();

	void Start () {
        d = new Done();
        popUpD = new Done();
        bg = Scene_GettingObjs.getObjs().Canvas.GetComponent<Background>();
        p = Scene_GettingObjs.getObjs().PopUp.GetComponent<PopUp>();
        phone = Scene_GettingObjs.getObjs().PhonePopUp.GetComponent<PopUp>();
        bg.wr.fillMap();
        bg.wr.fillList();
	}
	
	void Update () {
        //if on a particular screen and no buttons are being pressed don't do anything
        if (!d.done)
        {
            sceneAllButtons();
            sceneEnvZoomButtons();
            sceneGunButtons();
         //   sceneEnvContButtons();
            sceneFPButtons();
            sceneFPUpButtons();
            sceneFPDownButtons();
            sceneFPDownMapButtons();
            sceneFPDownLetterButtons();
            sceneFPUpPicLButtons();
            sceneFPUpPicRButtons();
            sceneWineTableButtons();
            sceneWineBottleButtons();
            sceneWineGlassFButtons();
            sceneWineGlassEButtons();
            sceneBodyButtons();
            sceneHandButtons();
            sceneRoundTableButtons();
            sceneGoldPhoneButtons();
            sceneRTPapersButtons();
            sceneRTPaper1Buttons();
            sceneRTPaper2Buttons();
            scenePBookCaseButtons();
            sceneCouchButtons();
            sceneCouchPillowButtons();
            sceneCouchBookButtons();
            sceneCouchCDButtons();
            sceneFPMessButtons();
            sceneFPMessLogButtons();
            sceneFPMessPaper1Buttons();
            sceneFPMessPaper2Buttons();
            sceneFPRightButtons();
            sceneFPLeftButtons();
            sceneBinderButtons();
            sceneShovelButtons();
            scenePickButtons();
            sceneBroomButtons();
            sceneForkButtons();
            this.sceneDadPicButtons();
            this.sceneWallPicsButtons();
            sceneShelfLeftButtons();
            this.sceneClockButtons();
            this.sceneTigerButtons();
            this.sceneGlobeButtons();
            this.sceneBBookCaseButtons();
            this.sceneGBookCaseButtons();
            this.sceneTicketButtons();
            this.sceneBBookCaseUpButtons();
            sceneShelfRightButtons();
            this.sceneCupButtons();
            this.sceneCupLookButtons();
            this.sceneJarButtons();
            this.sceneJarOpenButtons();
            this.sceneHeadButtons();
            this.sceneAwardButtons();
            this.sceneAwardZoomButtons();
            this.sceneStatueButtons();
            sceneGContactsButtons();
            sceneStacyButtons();
            sceneStacyZmButtons();
            sceneStacy2Buttons();
            sceneStacyZm2Buttons();
            sceneDadButtons();
            sceneDadZmButtons();
            sceneDad2Buttons();
            sceneDadZm2Buttons();
            sceneBoomBoxOpenButtons();
            sceneBoomBoxCloseButtons();
            scenePurplePhoneButtons();
            scenePContactsButtons();
            sceneFareedButtons();
            sceneFareedZmButtons();
            sceneFareed2Buttons();
            sceneFareedZm2Buttons();
            sceneFareed3Buttons();
            sceneFareedZm3Buttons();
            sceneSLBooksButtons();
            sceneAnthraxBookButtons(); 
        }

        else if (!popUpD.done && p.getShow()) 
            scenePopUp();
	}

    void scenePopUp()
    {
        controller.buttonProcess(d, popUpD, p.getShow(), new CBScenePopUp());
    }

    void sceneAllButtons()
    {
        controller.buttonProcess(d, popUpD, bg.wr.map["WHOLE_ROOM"], new CBSceneAll());
    }

    void sceneEnvZoomButtons()
    {
        controller.buttonProcess(d, popUpD, bg.wr.map["ENVELOPE"], new CBSceneEnvZoom());
    }

    //void sceneEnvContButtons()
    //{
    //    controller.buttonProcess(d, popUpD, bg.wr.map["ENVELOPE_CONT"], new CBSceneEnvCont());
    //}

    void sceneGunButtons()
    {
        controller.buttonProcess(d, popUpD, bg.wr.map["GUN"],new CBSceneGun());
    }


    void sceneFPButtons()
    {
        PBSceneFP pb = new PBSceneFP();
        pb.sceneButtons(d, popUpD, bg.wr.map["FIREPLACE"]);

    }

    void sceneFPUpButtons()
    {
        PBSceneFPUp pb = new PBSceneFPUp();
        pb.sceneButtons(d, popUpD, bg.wr.map["FIREPLACE_UP"]);

    }

    void sceneFPUpPicLButtons()
    {
        PBSceneFPPicL pb = new PBSceneFPPicL();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPU_PICL"]);

    }

    void sceneFPUpPicRButtons()
    {
        PBSceneFPPicR pb = new PBSceneFPPicR();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPU_PICR"]);

    }

    void sceneFPDownButtons()
    {
        PBSceneFPDown pb = new PBSceneFPDown();
        pb.sceneButtons(d, popUpD, bg.wr.map["FIREPLACE_DOWN"]);

    }

    void sceneFPDownMapButtons()
    {
        PBSceneFPMap pb = new PBSceneFPMap();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPD_MAP"]);

    }

    void sceneFPDownLetterButtons()
    {
        PBSceneFPLetter pb = new PBSceneFPLetter();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPD_LETTER"]);

    }

    void sceneWineTableButtons()
    {
        PBSceneWineTable pb = new PBSceneWineTable();
        pb.sceneButtons(d, popUpD, bg.wr.map["TABLE"]);

    }

    void sceneWineBottleButtons()
    {
        PBSceneWineBottle pb = new PBSceneWineBottle();
        pb.sceneButtons(d, popUpD, bg.wr.map["TABLE_WINEBOTTLE"]);

    }

    void sceneWineGlassFButtons()
    {
        PBSceneWineGlassF pb = new PBSceneWineGlassF();
        pb.sceneButtons(d, popUpD, bg.wr.map["TABLE_FWINEGLASS"]);

    }

    void sceneWineGlassEButtons()
    {
        PBSceneWineGlassE pb = new PBSceneWineGlassE();
        pb.sceneButtons(d, popUpD, bg.wr.map["TABLE_EWINEGLASS"]);

    }

    void sceneBodyButtons()
    {
        PBSceneBody pb = new PBSceneBody();
        pb.sceneButtons(d, popUpD, bg.wr.map["BODY"]);

    }

    void sceneHandButtons()
    {
        PBSceneHand pb = new PBSceneHand();
        pb.sceneButtons(d, popUpD, bg.wr.map["HAND"]);

    }

    void sceneRoundTableButtons()
    {
        PBSceneRoundTable pb = new PBSceneRoundTable();
        pb.sceneButtons(d, popUpD, bg.wr.map["ROUNDTABLE"]);

    }

    void sceneGoldPhoneButtons()
    {
        PBSceneGoldPhone pb = new PBSceneGoldPhone();
        pb.sceneButtons(d, popUpD, bg.wr.map["GOLDPHONE"]);

    }

    void sceneRTPapersButtons()
    {
        PBSceneRTPapers pb = new PBSceneRTPapers();
        pb.sceneButtons(d, popUpD, bg.wr.map["RT_PAPERS"]);

    }

    void sceneRTPaper1Buttons()
    {
        PBSceneRTPaper1 pb = new PBSceneRTPaper1();
        pb.sceneButtons(d, popUpD, bg.wr.map["RT_PAPER1"]);

    }

    void sceneRTPaper2Buttons()
    {
        PBSceneRTPaper2 pb = new PBSceneRTPaper2();
        pb.sceneButtons(d, popUpD, bg.wr.map["RT_PAPER2"]);

    }

    void scenePBookCaseButtons()
    {
        PBScenePurpleBookCase pb = new PBScenePurpleBookCase();
        pb.sceneButtons(d, popUpD, bg.wr.map["P_BOOKCASE"]);

    }

    void sceneCouchButtons()
    {
        PBSceneCouch pb = new PBSceneCouch();
        pb.sceneButtons(d, popUpD, bg.wr.map["COUCH"]);

    }

    void sceneCouchPillowButtons()
    {
        PBSceneCouchPillow pb = new PBSceneCouchPillow();
        pb.sceneButtons(d, popUpD, bg.wr.map["COUCH_PILLOW"]);

    }

    void sceneCouchBookButtons()
    {
        PBSceneCouchBook pb = new PBSceneCouchBook();
        pb.sceneButtons(d, popUpD, bg.wr.map["COUCH_BOOK"]);

    }

    void sceneCouchCDButtons()
    {
        PBSceneCouchCD pb = new PBSceneCouchCD();
        pb.sceneButtons(d, popUpD, bg.wr.map["COUCH_CD_OPEN"]);

    }

    void sceneFPMessButtons()
    {
        PBSceneFPMess pb = new PBSceneFPMess();
        pb.sceneButtons(d, popUpD, bg.wr.map["FP_MESS"]);

    }

    void sceneFPMessLogButtons()
    {
        PBSceneFPMessLog pb = new PBSceneFPMessLog();
        pb.sceneButtons(d, popUpD, bg.wr.map["FP_MESS_LOG"]);

    }

    void sceneFPMessPaper1Buttons()
    {
        PBSceneFPMessPaper1 pb = new PBSceneFPMessPaper1();
        pb.sceneButtons(d, popUpD, bg.wr.map["FP_MESS_PAPER1"]);

    }

    void sceneFPMessPaper2Buttons()
    {
        PBSceneFPMessPaper2 pb = new PBSceneFPMessPaper2();
        pb.sceneButtons(d, popUpD, bg.wr.map["FP_MESS_PAPER2"]);

    }

    void sceneFPRightButtons()
    {
        PBSceneFPRight pb = new PBSceneFPRight();
        pb.sceneButtons(d, popUpD, bg.wr.map["FIREPLACE_RIGHT"]);

    }

    void sceneFPLeftButtons()
    {
        PBSceneFPLeft pb = new PBSceneFPLeft();
        pb.sceneButtons(d, popUpD, bg.wr.map["FIREPLACE_LEFT"]);

    }

    void sceneBinderButtons()
    {
        PBSceneBinder pb = new PBSceneBinder();
        pb.sceneButtons(d, popUpD, bg.wr.map["BINDER"]);

    }

    void sceneShovelButtons()
    {
        PBSceneShovel pb = new PBSceneShovel();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPACC_SHOVEL"]);

    }

    void scenePickButtons()
    {
        PBScenePick pb = new PBScenePick();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPACC_PICK"]);

    }

    void sceneBroomButtons()
    {
        PBSceneBroom pb = new PBSceneBroom();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPACC_BROOM"]);

    }

    void sceneForkButtons()
    {
        PBSceneFork pb = new PBSceneFork();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPACC_FORK"]);

    }

    void sceneDadPicButtons()
    {
        PBSceneDadPic pb = new PBSceneDadPic();
        pb.sceneButtons(d, popUpD, bg.wr.map["DAD_PIC"]);

    }

    void sceneWallPicsButtons()
    {
        PBSceneWallPic pb = new PBSceneWallPic();
        pb.sceneButtons(d, popUpD, bg.wr.map["WALL_PICS"]);

    }

    void sceneShelfLeftButtons()
    {
        PBSceneShelfLeft pb = new PBSceneShelfLeft();
        pb.sceneButtons(d, popUpD, bg.wr.map["SHELF_LEFT"]);

    }

    void sceneClockButtons()
    {
        PBSceneClock pb = new PBSceneClock();
        pb.sceneButtons(d, popUpD, bg.wr.map["CLOCK"]);

    }

    void sceneTigerButtons()
    {
        PBSceneTiger pb = new PBSceneTiger();
        pb.sceneButtons(d, popUpD, bg.wr.map["TIGER"]);

    }

    void sceneGlobeButtons()
    {
        PBSceneGlobe pb = new PBSceneGlobe();
        pb.sceneButtons(d, popUpD, bg.wr.map["GLOBE"]);

    }

    void sceneSLBooksButtons()
    {
        PBSceneSLBooks pb = new PBSceneSLBooks();
        pb.sceneButtons(d, popUpD, bg.wr.map["SL_BOOKS"]);

    }

    void sceneAnthraxBookButtons()
    {
        PBSceneAnthraxBook pb = new PBSceneAnthraxBook();
        pb.sceneButtons(d, popUpD, bg.wr.map["ANTHRAX_BOOK"]);
    }

    void sceneBBookCaseButtons()
    {
        PBSceneBlueBookCase pb = new PBSceneBlueBookCase();
        pb.sceneButtons(d, popUpD, bg.wr.map["B_BOOKCASE"]);

    }

    void sceneGBookCaseButtons()
    {
        PBSceneGreenBookCase pb = new PBSceneGreenBookCase();
        pb.sceneButtons(d, popUpD, bg.wr.map["G_BOOKCASE"]);

    }

    void sceneTicketButtons()
    {
        PBSceneTicket pb = new PBSceneTicket();
        pb.sceneButtons(d, popUpD, bg.wr.map["TICKET"]);

    }

    void sceneBBookCaseUpButtons()
    {
        PBSceneBBookCaseUp pb = new PBSceneBBookCaseUp();
        pb.sceneButtons(d, popUpD, bg.wr.map["BBOOKCASE_UP"]);

    }

    void sceneShelfRightButtons()
    {
        PBSceneShelfRight pb = new PBSceneShelfRight();
        pb.sceneButtons(d, popUpD, bg.wr.map["SHELF_RIGHT"]);

    }

    void sceneCupButtons()
    {
        PBSceneCup pb = new PBSceneCup();
        pb.sceneButtons(d, popUpD, bg.wr.map["CUP"]);

    }

    void sceneCupLookButtons()
    {
        PBSceneCupLook pb = new PBSceneCupLook();
        pb.sceneButtons(d, popUpD, bg.wr.map["CUPLOOK"]);

    }

    void sceneJarButtons()
    {
        PBSceneJar pb = new PBSceneJar();
        pb.sceneButtons(d, popUpD, bg.wr.map["JAR"]);

    }

    void sceneJarOpenButtons()
    {
        PBSceneJarLook pb = new PBSceneJarLook();
        pb.sceneButtons(d, popUpD, bg.wr.map["JARLOOK"]);

    }

    void sceneHeadButtons()
    {
        PBSceneHead pb = new PBSceneHead();
        pb.sceneButtons(d, popUpD, bg.wr.map["HEAD"]);

    }

    void sceneAwardButtons()
    {
        PBSceneAward pb = new PBSceneAward();
        pb.sceneButtons(d, popUpD, bg.wr.map["AWARD"]);

    }

    void sceneAwardZoomButtons()
    {
        PBSceneAwardZoom pb = new PBSceneAwardZoom();
        pb.sceneButtons(d, popUpD, bg.wr.map["AWARDZM"]);
    }

    void sceneStatueButtons()
    {
        PBSceneStatue pb = new PBSceneStatue();
        pb.sceneButtons(d, popUpD, bg.wr.map["STATUE"]);

    }

    void sceneGContactsButtons()
    {
        PBSceneGContacts pb = new PBSceneGContacts();
        pb.sceneButtons(d, popUpD, bg.wr.map["GOLDPH_CONTACTS"]);

    }

    void scenePContactsButtons()
    {
        PBScenePContacts pb = new PBScenePContacts();
        pb.sceneButtons(d, popUpD, bg.wr.map["PURPLEPH_CONTACTS"]);

    }

    void sceneStacyButtons()
    {
        PBSceneStacy pb = new PBSceneStacy();
        pb.sceneButtons(d, popUpD, bg.wr.map["GOLDPH_STACY"]);

    }

    void sceneFareedButtons()
    {
        PBSceneFareed pb = new PBSceneFareed();
        pb.sceneButtons(d, popUpD, bg.wr.map["PURPLEPH_FAREED"]);

    }

    void sceneDadButtons()
    {
        PBSceneDad pb = new PBSceneDad();
        pb.sceneButtons(d, popUpD, bg.wr.map["GOLDPH_DAD"]);

    }

    void sceneDad2Buttons()
    {
        PBSceneDad2 pb = new PBSceneDad2();
        pb.sceneButtons(d, popUpD, bg.wr.map["GOLDPH_DAD_MESS2"]);

    }

    void sceneStacyZmButtons()
    {
        PBSceneStacyZm pb = new PBSceneStacyZm();
        pb.sceneButtons(d, popUpD, phone.StacyPhone);
    }

    void sceneFareedZmButtons()
    {
        PBSceneFareedZm pb = new PBSceneFareedZm();
        pb.sceneButtons(d, popUpD, phone.FareedPhone);
    }

    void sceneDadZmButtons()
    {
        PBSceneDadZm pb = new PBSceneDadZm();
        pb.sceneButtons(d, popUpD, phone.getShowPhone()); 
    }

    void sceneStacy2Buttons()
    {
        PBSceneStacy2 pb = new PBSceneStacy2();
        pb.sceneButtons(d, popUpD, bg.wr.map["GOLDPH_STACY_MESS2"]);
       

    }

    void sceneFareed2Buttons()
    {
        PBSceneFareed2 pb = new PBSceneFareed2();
        pb.sceneButtons(d, popUpD, bg.wr.map["PURPLEPH_FAREED_MESS2"]);
       
    }

    void sceneFareed3Buttons()
    {
        PBSceneFareed3 pb = new PBSceneFareed3();
        pb.sceneButtons(d, popUpD, bg.wr.map["PURPLEPH_FAREED_MESS3"]);

    }

    void sceneFareedZm2Buttons()
    {
        PBSceneFareedZm2 pb = new PBSceneFareedZm2();
        pb.sceneButtons(d, popUpD, phone.FareedPhone2);
    }

    void sceneFareedZm3Buttons()
    {
        PBSceneFareedZm3 pb = new PBSceneFareedZm3();
        pb.sceneButtons(d, popUpD, phone.FareedPhone3);
    }

    void sceneStacyZm2Buttons()
    {
        PBSceneStacyZm2 pb = new PBSceneStacyZm2();
        pb.sceneButtons(d, popUpD, phone.StacyPhone2);
    }

    void sceneDadZm2Buttons()
    {
       // PBSceneDadZm2 pb = new PBSceneDadZm2();
       // pb.sceneButtons(d, popUpD, phone.getShowPhone2()); 
        controller.buttonProcess(d, popUpD, phone.getShowPhone2(), new CBSceneDadZm2());
    }

    void sceneBoomBoxOpenButtons()
    {
        PBSceneFPBoomBox pb = new PBSceneFPBoomBox();
        pb.sceneButtons(d, popUpD, bg.wr.map["BOOMBOX_OPEN"]);
    }

    void sceneBoomBoxCloseButtons()
    {
       // PBSceneBBInspect pb = new PBSceneBBInspect();
       // pb.sceneButtons(d, popUpD, bg.wr.map["FPU_BOOMBOX"]);
        controller.buttonProcess(d, popUpD, bg.wr.map["FPU_BOOMBOX"],new CBSceneFPBoomBoxClose());
    }

    void scenePurplePhoneButtons()
    {
        PBSceneFPPhone pb = new PBSceneFPPhone();
        pb.sceneButtons(d, popUpD, bg.wr.map["FPU_PHONE"]);
    }
}
