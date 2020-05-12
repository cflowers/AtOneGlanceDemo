using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class AnsFields : MonoBehaviour {

    InputField[] arr = new InputField[8];
    public Canvas popUp;
    public Dictionary<int,string> ansDic = new Dictionary<int,string>();
    //GameObject popUpLis;
  
	void Start () {
       // popUpLis = GameObject.FindGameObjectWithTag("popUpLis");
        // GameObject field = Resources.Load("Prefab/Ans") as GameObject;
        // float currentY = field.transform.position.y;
        // int currentIndex = 1;


        // for (int i = 0; i < arr.Length; i++)
        // {
        //     arr[i] = GameObject.Instantiate(field).GetComponent<InputField>();
        //     arr[i].name = arr[i].name + currentIndex;
        //     arr[i].transform.SetParent(this.GetComponent<Canvas>().transform);
        //     arr[i].GetComponent<RectTransform>().anchoredPosition = new Vector3(field.transform.position.x, currentY, 0);
        //     arr[i].GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
        //     arr[i].GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        //     arr[i].GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        //     currentY = currentY - 46;
        //     currentIndex = currentIndex + 1;
        //     arr[i].onValueChanged.AddListener(delegate { lis_reveal(); });
        // }

        
	}

    // public void loadAnswers()
    // {
    //     if (LapTopInfo.Dat != null)
    //     {
    //         for (int i = 1; i < 9; i++)
    //         {
    //             if (LapTopInfo.Dat.AnsDic.ContainsKey(i))
    //             {
    //                 arr[i - 1].text = LapTopInfo.Dat.AnsDic[i];
    //             }
    //         }
    //     }
    // }

    // void lis_reveal()
    // {
        
    //     if (EventSystem.current.currentSelectedGameObject.name.Contains("1") &&
    //         EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "LISA HAWK")
    //             correct(1, "LISA HAWK");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("2") &&
    //              EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "ARCHAELOGIST")
    //             correct(2, "ARCHAELOGIST");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("3") &&
    //              EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "AMERICAN")
    //             correct(3, "AMERICAN");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("4") &&
    //              EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "YES")
    //             correct(4, "YES");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("5") &&
    //             EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "EGYPT")
    //             correct(5, "EGYPT");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("6") &&
    //             EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "FAREED")
    //             correct(6, "FAREED");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("7") &&
    //             EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "EGYPT")
    //             correct(7, "EGYPT");
    //     else if (EventSystem.current.currentSelectedGameObject.name.Contains("8") &&
    //             EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text == "YES,TERRORISM")
    //             correct(8, "YES, TERRORISM");

    
    // }

    // private void correct(int num, string ans)
    // {
    //     Debug.Log("Answer is correct");
    //     Debug.Log(EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().text);

    //     Color newColor = Color.green;
    //     ColorBlock cb = EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().colors;
    //     cb.normalColor = newColor;
    //     EventSystem.current.currentSelectedGameObject.GetComponent<InputField>().colors = cb;
    //     ansDic.Add(num, ans);
    // }

   
}
