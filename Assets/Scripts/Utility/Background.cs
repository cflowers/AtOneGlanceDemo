using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

/**
 * This class holds the constants of the images
 * 
 * It holds the methods that changes the images
 * in the game
 * 
 * It changes the fire of the fireplace
 * 
 * If images needs to be added, developer
 * should start here
 */ 
public class Background : MonoBehaviour
{
    public Texture2D[] textures;
    public LinkedList<CrimeTex> linkedList;
    public LinkedList<FireSheet> fireObjs;
    public WhichRoom wr = new WhichRoom();
    public GameObject fire;
    RawImage rawImageComp;
    AnimationCode animCode;
    const int WHOLE_ROOM = 0;
    const int ENVELOPE = 1;
    const int ENVELOPE_CONT = 2;
    const int FIREPLACE = 3;
    const int FIREPLACE_UP = 4;
    const int FIREPLACE_DOWN = 5;
    const int FPD_MAP = 6;
    const int FPD_LETTER = 7;
    const int FPU_BOOMBOX = 8;
    const int FPU_PICL = 9;
    const int FPU_PICR = 10;
    const int FPU_PHONE = 11;
    const int TABLE = 12;
    const int TABLE_WINEBOTTLE = 13;
    const int TABLE_FWINEGLASS = 14;
    const int TABLE_EWINEGLASS = 15;
    const int BODY = 16;
    const int HAND = 17;
    const int ROUNDTABLE = 18;
    const int GOLDPHONE = 19;
    const int RT_PAPERS = 20;
    const int RT_PAPER1 = 21;
    const int RT_PAPER2 = 22;
    const int P_BOOKCASE = 23;
    const int COUCH = 24;
    const int COUCH_PILLOW = 25;
    const int COUCH_BOOK = 26;
    const int COUCH_CD_OPEN = 27;
    const int FP_MESS = 28;
    const int FP_MESS_PAPER1 = 29;
    const int FP_MESS_PAPER2 = 30;
    const int FP_MESS_LOG = 31;
    const int FIREPLACE_RIGHT = 32;
    const int FIREPLACE_LEFT = 33;
    const int BINDER = 34;
    const int FPACC_SHOVEL = 35;
    const int FPACC_PICK = 36;
    const int FPACC_BROOM = 37;
    const int FPACC_FORK = 38;
    const int WALL_PICS = 39;
    const int DAD_PIC = 40;
    const int SHELF_LEFT = 41;
    const int CLOCK = 42;
    const int TIGER = 43;
    const int GLOBE = 44;
    const int SL_BOOKS = 45;
    const int B_BOOKCASE = 46;
    const int G_BOOKCASE = 47;
    const int TICKET = 48;
    const int BBOOKCASE_UP = 49;
    const int SHELF_RIGHT = 50;
    const int CUP = 51;
    const int JAR = 52;
    const int HEAD = 53;
    const int AWARD = 54;
    const int STATUE = 55;
    const int CUPLOOK = 56;
    const int JARLOOK = 57;
    const int AWARDZM = 58;
    const int GOLDPH_CONTACTS = 59;
    const int GOLDPH_STACY = 60;
    const int GOLDPH_STACY_ZM = 61;
    const int GOLDPH_STACY_MESS2 = 62;
    const int GOLDPH_STACY_ZM2 = 63;
    const int GOLDPH_DAD = 64;
    const int GOLDPH_DAD_ZM = 65;
    const int GOLDPH_DAD_MESS2 = 66;
    const int GOLDPH_DAD_ZM2 = 67;
    const int BOOMBOX_OPEN = 68;
    const int PURPLEPH_CONTACTS = 69;
    const int PURPLEPH_FAREED = 70;
    const int PURPLEPH_FAREED_ZM = 71;
    const int PURPLEPH_FAREED_MESS2 = 72;
    const int PURPLEPH_FAREED_ZM2 = 73;
    const int PURPLEPH_FAREED_MESS3 = 74;
    const int PURPLEPH_FAREED_ZM3 = 75;
    const int ANTHRAX_BOOK = 76;
    const int GUN = 77;
    string current = "";

    void Awake()
    {
        rawImageComp = GetComponentInChildren<RawImage>();
        rawImageComp.texture = textures[WHOLE_ROOM];
        current = "WHOLE_ROOM";
        fire = GameObject.FindGameObjectWithTag("testTex");
        fire.GetComponent<RectTransform>().anchoredPosition = new Vector2(-88.0f, 82.0f);
        animCode = GetComponent<AnimationCode>();
        animCode.beginAnimation(fire.GetComponent<RawImage>(), 
            "textures/level1/animations/FireplaceSprites/AllRoomSprites");
        fireObjs = new LinkedList<FireSheet>();
        fireObjs.AddLast(new FireSheet(fire.GetComponent<RectTransform>().anchoredPosition, 
            "textures/level1/animations/FireplaceSprites/AllRoomSprites"));
        linkedList = new LinkedList<CrimeTex>();
        linkedList.AddLast(new CrimeTex(textures[WHOLE_ROOM], "WHOLE_ROOM"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    void changeCurrent(string newCurrent)
    {
        wr.map[newCurrent] = true;
        wr.map[current] = false;
        current = newCurrent;
    }

    public void envelope()
    {
        linkedList.AddLast(new CrimeTex(textures[ENVELOPE], "ENVELOPE"));
        rawImageComp.texture = textures[ENVELOPE];
        changeCurrent("ENVELOPE");
       // wr.boolHandle(linkedList.Last.Value.name);
    }

    public void envelopeContents()
    {
        linkedList.AddLast(new CrimeTex(textures[ENVELOPE_CONT], "ENVELOPE_CONT"));
        rawImageComp.texture = textures[ENVELOPE_CONT];
        changeCurrent("ENVELOPE_CONT");
       // wr.boolHandle(linkedList.Last.Value.name);
    }

    public void gun()
    {
        linkedList.AddLast(new CrimeTex(textures[GUN], "GUN"));
        rawImageComp.texture = textures[GUN];
        changeCurrent("GUN");
      //  wr.boolHandle(linkedList.Last.Value.name);
    }

    public void body()
    {
        linkedList.AddLast(new CrimeTex(textures[BODY], "BODY"));
        rawImageComp.texture = textures[BODY];
        changeCurrent("BODY");
        //wr.boolHandle(linkedList.Last.Value.name);
    }

    public void hand()
    {
        linkedList.AddLast(new CrimeTex(textures[HAND], "HAND"));
        rawImageComp.texture = textures[HAND];
        changeCurrent("HAND");
       // wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplace()
    {
        linkedList.AddLast(new CrimeTex(textures[FIREPLACE], "FIREPLACE"));
        rawImageComp.texture = textures[FIREPLACE];
        animCode = GetComponent<AnimationCode>();
        fire.GetComponent<RectTransform>().anchoredPosition = new Vector2(-7.0f, 3.0f);
        fireObjs.AddLast(new FireSheet(fire.GetComponent<RectTransform>().anchoredPosition, 
            "textures/level1/animations/FireplaceSprites/FireplaceFront"));
        animCode.beginAnimation(fire.GetComponent<RawImage>(), 
            "textures/level1/animations/FireplaceSprites/FireplaceFront");
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceUp()
    {
        linkedList.AddLast(new CrimeTex(textures[FIREPLACE_UP], "FIREPLACE_UP"));
        rawImageComp.texture = textures[FIREPLACE_UP];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceDown()
    {
        linkedList.AddLast(new CrimeTex(textures[FIREPLACE_DOWN], "FIREPLACE_DOWN"));
        rawImageComp.texture = textures[FIREPLACE_DOWN];
        animCode = GetComponent<AnimationCode>();
        fire.GetComponent<RectTransform>().anchoredPosition = new Vector2(-34.0f, -53.0f);
        fireObjs.AddLast(new FireSheet(fire.GetComponent<RectTransform>().anchoredPosition, 
            "textures/level1/animations/FireplaceSprites/FireplaceDown"));
        animCode.beginAnimation(fire.GetComponent<RawImage>(), 
            "textures/level1/animations/FireplaceSprites/FireplaceDown");
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceDown_map()
    {
        linkedList.AddLast(new CrimeTex(textures[FPD_MAP], "FPD_MAP"));
        rawImageComp.texture = textures[FPD_MAP];
        fire.GetComponent<RectTransform>().anchoredPosition = new Vector2(-45.0f, 115.0f);
        fireObjs.AddLast(new FireSheet(fire.GetComponent<RectTransform>().anchoredPosition, 
            "textures/level1/animations/FireplaceSprites/FireplaceDown"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceDown_letter()
    {
        linkedList.AddLast(new CrimeTex(textures[FPD_LETTER], "FPD_LETTER"));
        rawImageComp.texture = textures[FPD_LETTER];
        fire.GetComponent<RectTransform>().anchoredPosition = new Vector2(-45.0f, 115.0f);
        fireObjs.AddLast(new FireSheet(fire.GetComponent<RectTransform>().anchoredPosition, 
            "textures/level1/animations/FireplaceSprites/FireplaceDown"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceUp_boombox()
    {
        linkedList.AddLast(new CrimeTex(textures[FPU_BOOMBOX], "FPU_BOOMBOX"));
        rawImageComp.texture = textures[FPU_BOOMBOX];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceUp_picL()
    {
        linkedList.AddLast(new CrimeTex(textures[FPU_PICL], "FPU_PICL"));
        rawImageComp.texture = textures[FPU_PICL];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceUp_picR()
    {
        linkedList.AddLast(new CrimeTex(textures[FPU_PICR], "FPU_PICR"));
        rawImageComp.texture = textures[FPU_PICR];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceUp_phone()
    {
        linkedList.AddLast(new CrimeTex(textures[FPU_PHONE], "FPU_PHONE"));
        rawImageComp.texture = textures[FPU_PHONE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void wineTable()
    {
        linkedList.AddLast(new CrimeTex(textures[TABLE], "TABLE"));
        rawImageComp.texture = textures[TABLE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void wineTable_bottle()
    {
        linkedList.AddLast(new CrimeTex(textures[TABLE_WINEBOTTLE], "TABLE_WINEBOTTLE"));
        rawImageComp.texture = textures[TABLE_WINEBOTTLE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void wineTable_full_glass()
    {
        linkedList.AddLast(new CrimeTex(textures[TABLE_FWINEGLASS], "TABLE_FWINEGLASS"));
        rawImageComp.texture = textures[TABLE_FWINEGLASS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void wineTable_empty_glass()
    {
        linkedList.AddLast(new CrimeTex(textures[TABLE_EWINEGLASS], "TABLE_EWINEGLASS"));
        rawImageComp.texture = textures[TABLE_EWINEGLASS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void roundTable()
    {
        linkedList.AddLast(new CrimeTex(textures[ROUNDTABLE], "ROUNDTABLE"));
        rawImageComp.texture = textures[ROUNDTABLE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPHONE], "GOLDPHONE"));
        rawImageComp.texture = textures[GOLDPHONE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void rtPapers()
    {
        linkedList.AddLast(new CrimeTex(textures[RT_PAPERS], "RT_PAPERS"));
        rawImageComp.texture = textures[RT_PAPERS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void rtPaper1()
    {
        linkedList.AddLast(new CrimeTex(textures[RT_PAPER1], "RT_PAPER1"));
        rawImageComp.texture = textures[RT_PAPER1];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void rtPaper2()
    {
        linkedList.AddLast(new CrimeTex(textures[RT_PAPER2], "RT_PAPER2"));
        rawImageComp.texture = textures[RT_PAPER2];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void p_bookcase()
    {
        linkedList.AddLast(new CrimeTex(textures[P_BOOKCASE], "P_BOOKCASE"));
        rawImageComp.texture = textures[P_BOOKCASE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void couch()
    {
        linkedList.AddLast(new CrimeTex(textures[COUCH], "COUCH"));
        rawImageComp.texture = textures[COUCH];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void couchPillow()
    {
        linkedList.AddLast(new CrimeTex(textures[COUCH_PILLOW], "COUCH_PILLOW"));
        rawImageComp.texture = textures[COUCH_PILLOW];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void couchBook()
    {
        linkedList.AddLast(new CrimeTex(textures[COUCH_BOOK], "COUCH_BOOK"));
        rawImageComp.texture = textures[COUCH_BOOK];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void couchCD()
    {
        linkedList.AddLast(new CrimeTex(textures[COUCH_CD_OPEN], "COUCH_CD_OPEN"));
        rawImageComp.texture = textures[COUCH_CD_OPEN];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpMess()
    {
        linkedList.AddLast(new CrimeTex(textures[FP_MESS], "FP_MESS"));
        rawImageComp.texture = textures[FP_MESS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpMessPaper1()
    {
        linkedList.AddLast(new CrimeTex(textures[FP_MESS_PAPER1], "FP_MESS_PAPER1"));
        rawImageComp.texture = textures[FP_MESS_PAPER1];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpMessPaper2()
    {
        linkedList.AddLast(new CrimeTex(textures[FP_MESS_PAPER2], "FP_MESS_PAPER2"));
        rawImageComp.texture = textures[FP_MESS_PAPER2];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpMessLog()
    {
        linkedList.AddLast(new CrimeTex(textures[FP_MESS_LOG], "FP_MESS_LOG"));
        rawImageComp.texture = textures[FP_MESS_LOG];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceRight()
    {
        linkedList.AddLast(new CrimeTex(textures[FIREPLACE_RIGHT], "FIREPLACE_RIGHT"));
        rawImageComp.texture = textures[FIREPLACE_RIGHT];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fireplaceLeft()
    {
        linkedList.AddLast(new CrimeTex(textures[FIREPLACE_LEFT], "FIREPLACE_LEFT"));
        rawImageComp.texture = textures[FIREPLACE_LEFT];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void binder()
    {
        linkedList.AddLast(new CrimeTex(textures[BINDER], "BINDER"));
        rawImageComp.texture = textures[BINDER];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpAccShovel()
    {
        linkedList.AddLast(new CrimeTex(textures[FPACC_SHOVEL], "FPACC_SHOVEL"));
        rawImageComp.texture = textures[FPACC_SHOVEL];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpAccPick()
    {
        linkedList.AddLast(new CrimeTex(textures[FPACC_PICK], "FPACC_PICK"));
        rawImageComp.texture = textures[FPACC_PICK];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpAccBroom()
    {
        linkedList.AddLast(new CrimeTex(textures[FPACC_BROOM], "FPACC_BROOM"));
        rawImageComp.texture = textures[FPACC_BROOM];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void fpAccFork()
    {
        linkedList.AddLast(new CrimeTex(textures[FPACC_FORK], "FPACC_FORK"));
        rawImageComp.texture = textures[FPACC_FORK];
        wr.boolHandle(linkedList.Last.Value.name);
    }


    public void wallPics()
    {
        linkedList.AddLast(new CrimeTex(textures[WALL_PICS], "WALL_PICS"));
        rawImageComp.texture = textures[WALL_PICS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void dadPic()
    {
        linkedList.AddLast(new CrimeTex(textures[DAD_PIC], "DAD_PIC"));
        rawImageComp.texture = textures[DAD_PIC];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void shelfLeft()
    {
        linkedList.AddLast(new CrimeTex(textures[SHELF_LEFT], "SHELF_LEFT"));
        rawImageComp.texture = textures[SHELF_LEFT];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void clock()
    {
        linkedList.AddLast(new CrimeTex(textures[CLOCK], "CLOCK"));
        rawImageComp.texture = textures[CLOCK];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void tiger()
    {
        linkedList.AddLast(new CrimeTex(textures[TIGER], "TIGER"));
        rawImageComp.texture = textures[TIGER];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void globe()
    {
        linkedList.AddLast(new CrimeTex(textures[GLOBE], "GLOBE"));
        rawImageComp.texture = textures[GLOBE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void slBooks()
    {
        linkedList.AddLast(new CrimeTex(textures[SL_BOOKS], "SL_BOOKS"));
        rawImageComp.texture = textures[SL_BOOKS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void anthraxBook()
    {
        linkedList.AddLast(new CrimeTex(textures[ANTHRAX_BOOK], "ANTHRAX_BOOK"));
        rawImageComp.texture = textures[ANTHRAX_BOOK];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void b_bookcase()
    {
        linkedList.AddLast(new CrimeTex(textures[B_BOOKCASE], "B_BOOKCASE"));
        rawImageComp.texture = textures[B_BOOKCASE];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void g_bookcase()
    {
        linkedList.AddLast(new CrimeTex(textures[G_BOOKCASE], "G_BOOKCASE"));
        rawImageComp.texture = textures[G_BOOKCASE];
        wr.boolHandle(linkedList.Last.Value.name);
    }


    public void ticket()
    {
        linkedList.AddLast(new CrimeTex(textures[TICKET], "TICKET"));
        rawImageComp.texture = textures[TICKET];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void bbookcase_up()
    {
        linkedList.AddLast(new CrimeTex(textures[BBOOKCASE_UP], "BBOOKCASE_UP"));
        rawImageComp.texture = textures[BBOOKCASE_UP];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void shelfRight()
    {
        linkedList.AddLast(new CrimeTex(textures[SHELF_RIGHT], "SHELF_RIGHT"));
        rawImageComp.texture = textures[SHELF_RIGHT];
        wr.boolHandle(linkedList.Last.Value.name);
    }


    public void cup()
    {
        linkedList.AddLast(new CrimeTex(textures[CUP], "CUP"));
        rawImageComp.texture = textures[CUP];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void jar()
    {
        linkedList.AddLast(new CrimeTex(textures[JAR], "JAR"));
        rawImageComp.texture = textures[JAR];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void head()
    {
        linkedList.AddLast(new CrimeTex(textures[HEAD], "HEAD"));
        rawImageComp.texture = textures[HEAD];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void award()
    {
        linkedList.AddLast(new CrimeTex(textures[AWARD], "AWARD"));
        rawImageComp.texture = textures[AWARD];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void cupLook()
    {
        linkedList.AddLast(new CrimeTex(textures[CUPLOOK], "CUPLOOK"));
        rawImageComp.texture = textures[CUPLOOK];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void jarLook()
    {
        linkedList.AddLast(new CrimeTex(textures[JARLOOK], "JARLOOK"));
        rawImageComp.texture = textures[JARLOOK];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void awardZm()
    {
        linkedList.AddLast(new CrimeTex(textures[AWARDZM], "AWARDZM"));
        rawImageComp.texture = textures[AWARDZM];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void statue()
    {
        linkedList.AddLast(new CrimeTex(textures[STATUE], "STATUE"));
        rawImageComp.texture = textures[STATUE];
        wr.boolHandle(linkedList.Last.Value.name);
    }



    public void goldPhone_contacts()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_CONTACTS], "GOLDPH_CONTACTS"));
        //rawImageComp.texture = textures[GOLDPH_CONTACTS];
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_contacts()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_CONTACTS], "PURPLEPH_CONTACTS"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_fareed()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_FAREED], "PURPLEPH_FAREED"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_fareed2()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_FAREED_MESS2], "PURPLEPH_FAREED_MESS2"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_fareed3()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_FAREED_MESS3], "PURPLEPH_FAREED_MESS3"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_fareed_zm()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_FAREED_ZM], "PURPLEPH_FAREED_ZM"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_fareed_zm2()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_FAREED_ZM2], "PURPLEPH_FAREED_ZM2"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void purplePhone_fareed_zm3()
    {
        linkedList.AddLast(new CrimeTex(textures[PURPLEPH_FAREED_ZM3], "PURPLEPH_FAREED_ZM3"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_stacy()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_STACY], "GOLDPH_STACY"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_dad()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_DAD], "GOLDPH_DAD"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_stacy_zm()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_STACY_ZM], "GOLDPH_STACY_ZM"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_dad_zm()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_DAD_ZM], "GOLDPH_DAD_ZM"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_stacy_zm2()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_STACY_ZM2], "GOLDPH_STACY_ZM2"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_stacy_mess2()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_STACY_MESS2], "GOLDPH_STACY_MESS2"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_dad_zm2()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_DAD_ZM2], "GOLDPH_DAD_ZM2"));
        wr.boolHandle(linkedList.Last.Value.name);
    }

    public void goldPhone_dad_mess2()
    {
        linkedList.AddLast(new CrimeTex(textures[GOLDPH_DAD_MESS2], "GOLDPH_DAD_MESS2"));
        wr.boolHandle(linkedList.Last.Value.name);
    }


    public void boomBoxOpen()
    {
        linkedList.AddLast(new CrimeTex(textures[BOOMBOX_OPEN], "BOOMBOX_OPEN"));
        rawImageComp.texture = textures[BOOMBOX_OPEN];
        wr.boolHandle(linkedList.Last.Value.name);
    }


    public void back()
    {
        if (linkedList.Count > 1)
        {
            Debug.Log("Got here in back");
            linkedList.RemoveLast();
            changeCurrent(linkedList.Last.Value.name);
            wr.boolHandle(linkedList.Last.Value.name);
            Texture2D tex = linkedList.Last.Value.tex;
            rawImageComp.texture = tex;
            back_fire();
        }
    }

   
    void back_fire()
    {
       // Debug.Log("Back Fire:" + linkedList.Last.Value.name);
        if ((linkedList.Count == 1 && fireObjs.Count == 1) ||
            (linkedList.Last.Value.name.Equals("FIREPLACE") && fireObjs.Count == 2))
        {
            animCode.beginAnimation1 = true;
        }


        else if ((linkedList.Last.Value.name.Equals("FIREPLACE_UP") && fireObjs.Count == 2)||
                 (linkedList.Last.Value.name.Equals("FIREPLACE_LEFT") && fireObjs.Count == 2) ||
                 (linkedList.Last.Value.name.Equals("FPU_BOOMBOX") && fireObjs.Count == 2)
                )
        {
            animCode.beginAnimation1 = false;
        }


        else if (fireObjs.Count > 1)
        {
            Debug.Log("Count:" + fireObjs.Count);
            fireObjs.RemoveLast();
            Debug.Log("Last:" + fireObjs.Last.Value.name);
            Debug.Log("GOT HERE FIRE OBJS:" + fireObjs.Last.Value.pos);
            fire.GetComponent<RectTransform>().anchoredPosition = fireObjs.Last.Value.pos;
            animCode.beginAnimation(fire.GetComponent<RawImage>(), fireObjs.Last.Value.name);

        }
    }

}
