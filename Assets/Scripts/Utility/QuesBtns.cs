using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class QuesBtns : MonoBehaviour {

    public Text[] textArr = new Text[8];
    Button[] arr = new Button[8];
    public Canvas popUp;
    GameObject popUpLis;
    bool done = false;
    GameObject button;
	void Start () {
        button = Resources.Load("Prefab/RevealQues") as GameObject;
        createQuesBtns();
	}

    void Update()
    {
        if (!done)
        {
            GetComponent<Canvas>().enabled = false; 
            done = true;
        }
	}

    void createQuesBtns()
    {
        
        popUpLis = GameObject.FindGameObjectWithTag("popUpLis");
        //GameObject button = Resources.Load("Prefab/RevealQues") as GameObject;
        float currentY = button.transform.position.y;


        for (int i = 0; i < arr.Length; i++)
        {
           
            arr[i] = GameObject.Instantiate(button).GetComponent<Button>();
            arr[i].transform.SetParent(this.GetComponent<Canvas>().transform);
            arr[i].GetComponent<RectTransform>().sizeDelta = new Vector2(arr[i].GetComponent<RectTransform>().sizeDelta.x,
                textArr[i].GetComponent<RectTransform>().sizeDelta.y);
            arr[i].GetComponent<RectTransform>().anchoredPosition = new Vector3(button.transform.position.x,
               textArr[i].rectTransform.localPosition.y, 0);
            arr[i].GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            arr[i].GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            arr[i].GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            //currentY = currentY - 50;
            arr[i].onClick.AddListener(new UnityAction(delegate { lis_reveal(); }));
        }

        for (int i = 0; i < 9; i++)
        {
            if (LapTopInfo.Dat != null && LapTopInfo.Dat.AnsDic != null)
            {
                if (LapTopInfo.Dat.AnsDic.ContainsKey(i))
                {
                    arr[i - 1].interactable = false;
                    arr[i - 1].GetComponent<Image>().enabled = false;

                }
            }
        }
            
    }

    void lis_reveal()
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "btnQues")
        {
            popUp.enabled = true;
            popUpLis.GetComponent<PopUpLis>().setG(EventSystem.current.currentSelectedGameObject);
            //EventSystem.current.currentSelectedGameObject.SetActive(false);
        }
    }
   
}
