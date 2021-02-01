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

    Dictionary<string, SuspectGameObject> bufferMap = new Dictionary<string, SuspectGameObject>();

    public List<string> keys;

	
	void Start () {
        map.fillPanelMap();
        keys = new List<string>(map.Map.Keys);
        Debug.Log("Map:" + map.Map.Count);
        this.bufferMap = map.Map;
        foreach(string s in keys)
        Debug.Log(s);
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
        string name = sendInfo.getName().ToUpper().Trim();
        Debug.Log(name);
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
           else if (name.Equals(key))
           { Debug.Log("Key:" + key);
               valid = true;
               break;
           }
           
       }
        return valid;
    }

    bool validNameAlreadyInputted(string name, bool valid)
    {
        for(int i =0;i<nameList.size();i++)
        // foreach (string key in nameList)
         {
           
             if (name.Equals(nameList.get(i))){
                 Debug.Log("Key1:" + nameList.get(i));
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
            if (sendInfo.getName().ToUpper().Trim() == key)
            {
                Debug.Log("What:" + this.bufferMap.Count);
                suspectPic.texture = this.bufferMap[key].getImg();
                this.bufferMap[key].Entered = true;
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
            if (sendInfo.getName().ToUpper().Trim() == key)
            {
                Image btnImg = GameObject.FindGameObjectWithTag(this.bufferMap[key].getBtnName()).GetComponent<Image>();
                this.bufferMap[key].BtnImg = btnImg;
                Button btn = GameObject.FindGameObjectWithTag(this.bufferMap[key].getBtnName()).GetComponent<Button>();
               this.bufferMap[key].Btn = btn;
               
                this.bufferMap[key].Btn.interactable = true;
                this.bufferMap[key].BtnImg.enabled = true;
                break;
            }
        }
        isSuspectEnter = false;
    }


    
}
