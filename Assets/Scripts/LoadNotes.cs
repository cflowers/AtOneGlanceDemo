using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LoadNotes : MonoBehaviour {

    int index = 0;
    int nextSix = 6;
    int prevSix = 6;
    int rows = 0;
    PlaceHolder[] arr = new PlaceHolder[100];
    CFLinkedList<PlaceHolder> test = new CFLinkedList<PlaceHolder>();
    GameObject buttonsInter;
    GameObject screen;
    string name = null;
    Misc misc = new Misc();
    CFLinkedList<PanelUtility> list;
    public int indexList = 0;


    void Start()
    {
        if (WhichPanel.getInstance().List.size() > 0)
        {
            WhichPanel.Panel = WhichPanel.getInstance().List.getCurrent().Panel;
        }
        buttonsInter = GameObject.FindGameObjectWithTag("nextPanel"); 
        screen = GameObject.FindGameObjectWithTag("screen");
        
    }

 
    public void listener_next()
    {
        
         SendInfo sendInfo = screen.GetComponent<SendInfo>();
         name = sendInfo.getName();
         list = findNotesName(name);
             //if list is not at the end then go to next object
             // if list is at the end create new place holders
             if (indexList != list.size()-1)
             {
                 disablePlaceHolders();
                 nextPlaceHolders(list);
                 indexList++;
             }

             else if (indexList == list.size()-1)
             {
                 disablePlaceHolders();
                 createNewPlaceHolders(name);
                 indexList++;
             }
         

       buttonsInter.GetComponent<ButtonsInteraction>().onPage = true;
    }


    public void listener_previous()
    {
        SendInfo sendInfo = screen.GetComponent<SendInfo>();
        if (name != sendInfo.getName())
        {
            name = sendInfo.getName();
            list = findNotesName(name);
        }

        else if (name == sendInfo.getName())
        {
            disablePlaceHolders();
            prevPlaceHolders(list);
        }
        buttonsInter.GetComponent<ButtonsInteraction>().onPage = true;
    }

    private void disablePlaceHolders()
    {
     
        misc.helperPlaceHolders(false,WhichPanel.Panel);
        
    }

    void nextPlaceHolders(CFLinkedList<PanelUtility> list)
    {   
        WhichPanel.Panel = list.next().Panel;
        misc.helperPlaceHolders(true,WhichPanel.Panel);
    }

    /**
   * loop through notes to find the specified tag
   * and add it to resultList
   */
    CFLinkedList<PanelUtility> findNotesName(string name)
    {
       
        CFLinkedList<PanelUtility> resultList = new CFLinkedList<PanelUtility>();
        for (int i = 0; i < WhichPanel.getInstance().List.size(); i++)
        {
            if (WhichPanel.getInstance().List.get(i).Name == name)
            {
                resultList.Add(WhichPanel.getInstance().List.get(i));
            }
        }
        return resultList;
    }

    void prevPlaceHolders(CFLinkedList<PanelUtility> list)
    {
        WhichPanel.Panel = list.previous().Panel;
        misc.helperPlaceHolders(true, WhichPanel.Panel);
        indexList--;
    }

    void createNewPlaceHolders(string name)
    {
       //if current panel has 8 pictures placed on it then do the following
       
        GameObject panel = Resources.Load("Prefab/PlaceHolders1") as GameObject;
        panel.tag = createTag(name);
        GameObject bufPanel = GameObject.Instantiate(panel);
        GameObject mainPanel = GameObject.FindGameObjectWithTag("whatever");
        bufPanel.transform.SetParent(mainPanel.transform);
        bufPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(533, 322);
        GameObject holder = Resources.Load("Prefab/holder") as GameObject;
        setUpPlaceHolders(bufPanel, holder, -90);
        setUpPlaceHolders(bufPanel, holder, -180);
        WhichPanel.Panel = bufPanel;
        PanelUtility p = new PanelUtility(name, bufPanel);
        WhichPanel.getInstance().List.Add(p);

    }

    private string createTag(string name)
    {
        string tag = null;
        if (name == "LISA HAWK")
            tag = "placeHolderLisa";
        else if (name == "BRANDON HAWK")
            tag = "placeHolderDad";
        else if (name == "STACY HAWK")
            tag = "placeHolderSis";
        else if (name == "FAREED")
            tag = "placeHolderFareed";

        return tag;
    }

    private void setUpPlaceHolders(GameObject bufPanel, GameObject holder, float y)
    {
        float next = 90;
        float current = -321.5f;

        for (int i = 0; i < 4; i++)
        {
            GameObject bufHolder = GameObject.Instantiate(holder);
            bufHolder.transform.SetParent(bufPanel.transform);
            bufHolder.GetComponent<RectTransform>().anchoredPosition = new Vector2(current, y);
            current = current + next;
        }
    }

    private void helperPlaceHolders(bool e)
    {
        GameObject mainPH = WhichPanel.Panel;
        RawImage[] ri = mainPH.GetComponentsInChildren<RawImage>();
        Hover_Laptop[] h = mainPH.GetComponentsInChildren<Hover_Laptop>();
        Text[] t = mainPH.GetComponentsInChildren<Text>();
        Image[] img = mainPH.GetComponentsInChildren<Image>();
        Button[] button = mainPH.GetComponentsInChildren<Button>();

        for (int i = 0; i < ri.Length; i++)
        {

            ri[i].enabled = e;
            h[i].enabled = e;

            if (i < t.Length)
            {
                t[i].enabled = e;
                img[i].enabled = e;
                button[i].enabled = e;
            }
        }
    }


    public void listener_loadNotes()
    {
       
        nextImages();
       
    }


    public void destroyImages()
    {

        int count = test.size();
        for (int i = 0; i < count; i++)
        {
            if (test.get(i).go.tag == "picPh")
            {
                Destroy(test.get(i).go);
            }
        }

        for (int i = 0; i < count; i++)
            test.Remove();

        nextImages();
    }

    void nextImages()
    {
        rows = rows + 6;
    
        int width = 100;
        int current = 175;
        int space = 50;
        
        if (NotebookInfo.getNotebook() != null && index < NotebookInfo.getNotebook().getList().Count)
        {
            while (index < NotebookInfo.getNotebook().getList().Count && index < nextSix)
            {
                GameObject imgObj = Resources.Load("Prefab/ph") as GameObject;
                GameObject bufImg = GameObject.Instantiate(imgObj);
                GameObject panel = GameObject.FindGameObjectWithTag("whatever");
                bufImg.transform.SetParent(panel.transform);
                bufImg.GetComponent<RectTransform>().anchoredPosition = new Vector2(current, 52);
                bufImg.GetComponent<RectTransform>().anchorMin = new Vector2(0f, 1f);
                bufImg.GetComponent<RectTransform>().anchorMax = new Vector2(0f, 1f);
                bufImg.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
                // bufImg.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                bufImg.GetComponent<RawImage>().texture = NotebookInfo.getNotebook().getArr()[index].getPic();
                index++;
                PlaceHolder p = new PlaceHolder(bufImg, new Vector2(current, 250));
                test.Add(p);
                current = current + width + space;
            }
        }
        nextSix = nextSix + 6;
    }


   public void prevImages()
    {
        int count = test.size();
        for (int i = 0; i < count; i++)
        {
            if (test.get(i).go.tag == "picPh")
                Destroy(test.get(i).go);
        }

        for (int i = 0; i < count; i++)
            test.Remove();

       index = rows - 12;
       rows = rows - 12;
       nextSix = nextSix - 12;
       nextImages();
    }


    public PlaceHolder[] getPlaceHolders()
    {
        return arr;
    }



}
