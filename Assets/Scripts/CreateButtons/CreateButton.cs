using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;

public class CreateButton  {

    GameObject canvas;
    LinkedList<GameObject> buttons = new LinkedList<GameObject>();
   
    public void setCanvas(string c)
    {
        canvas = GameObject.FindGameObjectWithTag(c);     
    }

    public GameObject getCanvas()
    {
        return canvas;
    }

    public void createButtons(string name, Transform parent, Dictionary<string, Vector2> dicAnchors, UnityAction lis, bool showButton, bool interact)
    {
        GameObject button = Resources.Load("Prefab/sceneButton") as GameObject;
        GameObject bufButton = GameObject.Instantiate(button);
        bufButton.name = name;
        bufButton.transform.SetParent(parent);
        bufButton.GetComponent<Button>().enabled = interact;
        bufButton.GetComponent<RectTransform>().anchoredPosition = dicAnchors["buttonPos"];
        bufButton.GetComponent<RectTransform>().anchorMin = dicAnchors["anchorMin"];
        bufButton.GetComponent<RectTransform>().anchorMax = dicAnchors["anchorMax"];
        bufButton.GetComponent<RectTransform>().pivot = dicAnchors["pivot"];
        bufButton.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        bufButton.GetComponent<Button>().onClick.AddListener(lis);
        buttons.AddFirst(bufButton);
    }

    public void createButtons(Dictionary<string, CreateButtonsContents> buttonsDic)
    {
        if (!buttonsDic["map"].Inspection)
        {
            GameObject button = Resources.Load("Prefab/sceneButton") as GameObject;
            GameObject bufButton = GameObject.Instantiate(button);
            bufButton.name = buttonsDic["map"].Name;
            bufButton.transform.SetParent(buttonsDic["map"].Parent);
            bufButton.GetComponent<Button>().enabled = buttonsDic["map"].Interact;
            bufButton.GetComponent<RectTransform>().anchoredPosition = buttonsDic["map"].DicAnchors["buttonPos"];
            bufButton.GetComponent<RectTransform>().anchorMin = buttonsDic["map"].DicAnchors["anchorMin"];
            bufButton.GetComponent<RectTransform>().anchorMax = buttonsDic["map"].DicAnchors["anchorMax"];
            bufButton.GetComponent<RectTransform>().pivot = buttonsDic["map"].DicAnchors["pivot"];
            bufButton.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            bufButton.GetComponent<Button>().onClick.AddListener(buttonsDic["map"].Lis);
            buttons.AddFirst(bufButton);
        }
    }

    public LinkedList<GameObject> getButtons()
    {
        return buttons;
    }

    public void createWriteButton(Transform parent,Dictionary<string, Vector2> dicAnchor, UnityAction lis)
    {
        GameObject button = Resources.Load("Prefab/write") as GameObject;
        GameObject bufButton = GameObject.Instantiate(button);
        bufButton.transform.SetParent(parent);
        bufButton.GetComponent<RectTransform>().anchoredPosition = dicAnchor["buttonPos"];
        bufButton.GetComponent<RectTransform>().anchorMin = dicAnchor["anchorMin"];
        bufButton.GetComponent<RectTransform>().anchorMax = dicAnchor["anchorMax"];
        bufButton.GetComponent<RectTransform>().pivot = dicAnchor["pivot"];
        bufButton.GetComponent<Button>().onClick.AddListener(lis);
        buttons.AddFirst(bufButton);
    }

    public void createDontWriteButton(Transform parent,Dictionary<string, Vector2> dicAnchor, UnityAction lis)
    {
        GameObject button = Resources.Load("Prefab/dontwrite") as GameObject;
        GameObject bufButton = GameObject.Instantiate(button);
        bufButton.transform.SetParent(parent);
        bufButton.GetComponent<RectTransform>().anchoredPosition = dicAnchor["buttonPos"];
        bufButton.GetComponent<RectTransform>().anchorMin = dicAnchor["anchorMin"];
        bufButton.GetComponent<RectTransform>().anchorMax = dicAnchor["anchorMax"];
        bufButton.GetComponent<RectTransform>().pivot = dicAnchor["pivot"];
        bufButton.GetComponent<Button>().onClick.AddListener(lis); 
        buttons.AddFirst(bufButton);
    }


   
}
