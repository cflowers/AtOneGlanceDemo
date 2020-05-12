using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ListenerLaptop : MonoBehaviour
{

    GameObject bg;
    GameObject keyboardButton;
    GameObject winIcon;
    GameObject suspectScreen;
    GameObject screen;
    GameObject suspect;
    GameObject recSuspect;
    GameObject buttonsInter;

    GameObject hud_points;
    InputField input;
    LapTopLoadHelper helper;
    Misc misc;
    bool first = true;

    void Start()
    {
       
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Debug.Log("Scene 2:" + NotebookInfo.getNotebook().getArr()[0]);
             Debug.Log("Scene 2:" + NotebookInfo.getNotebook().getList().Count);
            bg = Scene2_GettingObjs.getObjs().Canvas;
            keyboardButton = Scene2_GettingObjs.getObjs().KeyboardButton;
            winIcon = Scene2_GettingObjs.getObjs().WinIcon;
            suspectScreen = Scene2_GettingObjs.getObjs().SuspectScreen;
            screen = Scene2_GettingObjs.getObjs().Screen;
            suspect = Scene2_GettingObjs.getObjs().Suspect;
            recSuspect = Scene2_GettingObjs.getObjs().RecSuspect;
            buttonsInter = Scene2_GettingObjs.getObjs().ButtonsInter;
            input = Scene2_GettingObjs.getObjs().Input.GetComponent<InputField>();
            helper = new LapTopLoadHelper();
            misc = new Misc();  
           GameObject.FindGameObjectWithTag("points2").GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
            //if this is not a new game
            helper.load(first);
            first = false;
        }
    }


    public void showLaptop()
    {
        bg.GetComponent<Canvas>().enabled = true;
        bg.GetComponent<OfficeBackground>().atComp();
        keyboardButton.GetComponent<Button>().enabled = true;
        suspectScreen.GetComponent<Canvas>().enabled = false;
    }

    public void press_keyboard()
    {
        bg.GetComponent<OfficeBackground>().onComp();
        keyboardButton.GetComponent<Button>().enabled = false;
        winIcon.GetComponent<Button>().enabled = true;
        winIcon.GetComponent<Image>().enabled = true;
        winIcon.GetComponentInChildren<Text>().enabled = true;
    }

    public void press_icon()
    {
        suspectScreen.GetComponent<Canvas>().enabled = true;
        winIcon.GetComponent<Button>().enabled = false;
        winIcon.GetComponent<Image>().enabled = false;
        winIcon.GetComponentInChildren<Text>().enabled = false;
        //Debug.Break();
       // loadSuspectButtons();
    }

    void loadSuspectButtons()
    {
        //loop through LapTopInfoEnableButtons list and enable buttons
        if (LapTopInfo.Dat.NewGame && LapTopInfo.Dat.NameList.size() > 0)
        {
            Debug.Log("Names:" + LapTopInfo.Dat.NameList.size());
            for (int i = 0; i < LapTopInfo.Dat.NameList.size(); i++)
            {
                Debug.Log("Hmmm...");
                Debug.Break();
                SendInfo sendInfo = screen.GetComponent<SendInfo>();
                sendInfo.setName(LapTopInfo.Dat.NameList.get(i));
                recSuspect.GetComponent<Text>().text = sendInfo.getName();

                //if (recSuspect.GetComponent<InputInfo>().checkInfo())
                //{
               //     recSuspect.GetComponent<InputInfo>().isButtonHit = true;

                //}
            }
        }
    }


    public void showSuspectScreen()
    {
        buttonsInter.GetComponent<ButtonsInteraction>().onPage = false;
        suspectScreen.GetComponent<Canvas>().enabled = true;
        screen.GetComponent<Canvas>().enabled = false;
        this.GetComponent<LoadNotes>().indexList = 0;
    }

    public void enter_suspect()
    {
        bg.GetComponent<Canvas>().enabled = false;
        SendInfo sendInfo = screen.GetComponent<SendInfo>();
        sendInfo.setName(suspect.GetComponent<Text>().text);
        recSuspect.GetComponent<Text>().text = sendInfo.getName();
        if (recSuspect.GetComponent<InputInfo>().checkInfo())
        {
            recSuspect.GetComponent<InputInfo>().isSuspectEnter = true;
            screen.GetComponent<Canvas>().enabled = true;
            suspectScreen.GetComponent<Canvas>().enabled = false;
            buttonsInter.GetComponent<ButtonsInteraction>().Name = recSuspect.GetComponent<Text>().text;
            buttonsInter.GetComponent<ButtonsInteraction>().onPage = true;
            misc.disableAllPlaceHolders();
            misc.createNewPlaceHolders(recSuspect.GetComponent<Text>().text, false);
            string tag = misc.createTag(recSuspect.GetComponent<Text>().text);
            GameObject panel = GameObject.FindGameObjectWithTag(tag);
            WhichPanel.Panel = panel;
            Debug.Log("Name:" + buttonsInter.GetComponent<ButtonsInteraction>().Name);
            LapTopInfo.EnabledButtons.Add(buttonsInter.GetComponent<ButtonsInteraction>().Name);
            LapTopInfo.Dat.saveSuspects();
            LapTopInfo.Dat.NewGame = false;
           
            
        }

        else if (!recSuspect.GetComponent<InputInfo>().checkInfo())
        {
            //make error sound effect
            input.text = "";
            Debug.Log("Not a valid entry");
        }
    }

    /**
     * This method is for the Suspect buttons
     * that only shows after you enter the suspect
     * in the input field correctly.
     * So except of inputting the suspect's name
     * repeatedly just press the generated button.
     * And that button will then call this method
     * loading the notes accordingly
     */ 
    public void enableBtns(string name)
    {
       
        bg.GetComponent<Canvas>().enabled = false;//get rid of the laptop image
        screen.GetComponent<Canvas>().enabled = true;//show the notes screen
        SendInfo sendInfo = screen.GetComponent<SendInfo>();
        sendInfo.setName(name);
        recSuspect.GetComponent<Text>().text = sendInfo.getName();//set the input field to what was typed
        suspectScreen.GetComponent<Canvas>().enabled = false; //disable the input suspect screen

       // screen.GetComponent<AnsFields>().loadAnswers();//load answers for the notescreen
        
        //load panels for the notescreen
        Debug.Log("Load:" + LapTopInfo.Dat.NewGame);
        helper.load(first);
        first = false;
        recSuspect.GetComponent<InputInfo>().isButtonHit = true;
        string tag = misc.createTag(name);
        misc.disableAllPlaceHolders();
        GameObject panel = GameObject.FindGameObjectWithTag(tag);
        WhichPanel.Panel = panel;
        if (WhichPanel.Panel != null)
            misc.helperPlaceHolders(true, WhichPanel.Panel);
        else if (WhichPanel.Panel == null)
            misc.createNewPlaceHolders(name, false);
        buttonsInter.GetComponent<ButtonsInteraction>().Name = name;
        buttonsInter.GetComponent<ButtonsInteraction>().onPage = true;
    }
}
