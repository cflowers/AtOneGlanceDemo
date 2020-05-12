using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class InputInfo : MonoBehaviour {

    SendInfo sendInfo;
    Texture2D img;
    RawImage suspectPic;
  //  public bool done = false;
    public bool isButtonHit = false;
    public bool isSuspectEnter = false;
    public CFLinkedList<string> nameList;
    public FillPanelMap map = new FillPanelMap();
    public List<string> keys;

	
	void Start () {
        map.fillPanelMap();
        keys = new List<string>(map.Map.Keys);
        Debug.Log(keys);
        sendInfo = Scene2_GettingObjs.getObjs().Screen.GetComponent<SendInfo>();
        suspectPic = GameObject.FindGameObjectWithTag("suspectPic").GetComponent<RawImage>();
        //load names from dat file
        nameList = new CFLinkedList<string>();
        if (LapTopInfo.Dat != null)
            nameList = LapTopInfo.Dat.NameList;
	}
	
	
	void Update () {
        if (isButtonHit)
        {
         //   Debug.Log("Interesting");
          //  Debug.Break();
            setPic();
        }

        else if (isSuspectEnter)
        {
            setPic();
            revealButton();
        }
	}

    public bool checkInfo()
    {
        string name = sendInfo.getName();
        bool valid = true;
        valid = invalidInputName(name, valid) && validNameAlreadyInputted(name,valid);
        if(valid)
            nameList.Add(name);
        return valid;
    }

    bool invalidInputName(string name, bool valid)
    {
       foreach (string key in keys)
       {
           if (name != key)
               valid = false;
           else if (name == key)
           {
               valid = true;
               break;
           }
           
       }
        return valid;
    }

    bool validNameAlreadyInputted(string name, bool valid)
    {
        
         foreach (string key in keys)
         {
             Debug.Log(key);
             if (name == key && map.Map[key].Entered){
                 valid = false;
                 break;
             }
         }
       return valid;
    }

    //set picture in the load notes screen
    void setPic() {
        foreach (string key in keys)
        {
            if (sendInfo.getName().ToUpper() == key)
            {
                suspectPic.texture = map.Map[key].getImg();
                map.Map[key].Entered = true;
                //done = false;
                isButtonHit = false;
                break;
            }
        }
    }

    //if player already enter this suspect, reveal related button
    //in suspect screen
    void revealButton()
    {
        foreach (string key in keys)
        {
            if (sendInfo.getName().ToUpper() == key)
            {
                Image btnImg = GameObject.FindGameObjectWithTag(map.Map[key].getBtnName()).GetComponent<Image>();
                map.Map[key].BtnImg = btnImg;
                Button btn = GameObject.FindGameObjectWithTag(map.Map[key].getBtnName()).GetComponent<Button>();
                map.Map[key].Btn = btn;
                Debug.Log("Map:" + map.Map[key].Btn);
                Debug.Log("Map:" + map.Map[key].BtnImg);
                map.Map[key].Btn.interactable = true;
                map.Map[key].BtnImg.enabled = true;
                break;
            }
        }
        isSuspectEnter = false;
    }


    
}
