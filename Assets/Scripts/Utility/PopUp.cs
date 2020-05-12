using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    Text timer;
    Text clue;
    bool show = false;
    bool showPhone = false;
    bool showPhone2 = false;
    bool doneWriting = false;
    bool stacyPhone = false;
    bool stacyPhone2 = false;
    bool fareedPhone = false;
    bool fareedPhone2 = false;
    bool fareedPhone3 = false;
    ItemsFactory item;

    void Start()
    {
        if (this.CompareTag("phonePopUp"))
            timer = GameObject.FindGameObjectWithTag("timerPhone").GetComponentInChildren<Text>();
        else
            timer = GameObject.FindGameObjectWithTag("timerText").GetComponentInChildren<Text>();

        clue = GameObject.FindGameObjectWithTag("scrollbox").GetComponentInChildren<Text>();
    }

    void Update()
    {
        timer.text = "Timer: " + (int)TimerSC.getTimer().RemainingSeconds;
        if (item != null)
            clue.text = item.getTextFile();
           
        reset();
    }

    void reset()
    {
        if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && StacyPhone == true)
        {
            helperReset("stacyMess1Zm");
            StacyPhone = false;

        }

        else if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && StacyPhone2 == true)
        {
            helperReset("stacyMess2Zm");
            StacyPhone2 = false;
        }

        else if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && showPhone == true)
        {
            helperReset("dadMess1Zm");
            showPhone = false;
        }

        else if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && showPhone2 == true)
        {
            helperReset("dadMess2Zm");
            showPhone2 = false;
        }

        else if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && FareedPhone == true)
        {
            helperReset("fareedMess1Zm");
            FareedPhone = false;
        }

        else if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && FareedPhone2 == true)
        {
            helperReset("fareedMess2Zm");
            FareedPhone2 = false;
        }

        else if (TimerSC.getTimer().IsTicking && TimerSC.getTimer().RemainingSeconds == 0 && FareedPhone3 == true)
        {
            helperReset("fareedMess3Zm");
            FareedPhone3 = false;
        }

    }

    void helperReset(string prevMess)
    {
        Debug.Log("This happened");
        GameObject write = GameObject.FindGameObjectWithTag("writeBtn");
        GameObject dontWrite = GameObject.FindGameObjectWithTag("dontWriteBtn");
        Destroy(write);
        Destroy(dontWrite);
        GameObject hud_points = GameObject.FindGameObjectWithTag("points");
        GameObject phonePopUp = GameObject.FindGameObjectWithTag("phonePopUp");
        GameObject img = GameObject.FindGameObjectWithTag(prevMess);
        img.GetComponent<RawImage>().enabled = false;
        GameObject bg = GameObject.FindGameObjectWithTag("canvas");
        bg.GetComponent<Background>().back();
        bg.GetComponent<PlaceButtonsMain>().d.done = false;
        phonePopUp.GetComponent<Canvas>().sortingOrder = -1;
        int points = PlayerInfo.Points;
        PlayerInfo.Points = points - 10;
        hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
        TimerSC.getTimer().ResetTimer();
        TimerSC.getTimer().IsTicking = false;
    }

    public bool StacyPhone
    {
        get { return stacyPhone; }
        set { stacyPhone = value; }
    }

    public bool StacyPhone2
    {
        get { return stacyPhone2; }
        set { stacyPhone2 = value; }
    }

    public bool FareedPhone
    {
        get { return fareedPhone; }
        set { fareedPhone = value; }
    }

    public bool FareedPhone2
    {
        get { return fareedPhone2; }
        set { fareedPhone2 = value; }
    }

    public bool FareedPhone3
    {
        get { return fareedPhone3; }
        set { fareedPhone3 = value; }
    }


    public bool getShow()
    {
        return show;
    }

    public void setShow(bool show)
    {
        this.show = show;
    }

    public bool getShowPhone()
    {
        return showPhone;
    }

    public void setShowPhone(bool showPhone)
    {
        this.showPhone = showPhone;
    }

    public bool getShowPhone2()
    {
        return showPhone2;
    }

    public void setShowPhone2(bool showPhone2)
    {
        this.showPhone2 = showPhone2;
    }

    public ItemsFactory getItem()
    {
        return item;
    }

    public void setItem(ItemsFactory item)
    {
        this.item = item;
    }
}
