using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class ListenerSolve : MonoBehaviour {


    Misc misc = new Misc();
    string[] lines;
    [System.NonSerialized]
    public TextAsset textFile;
    bool whoBool = false;
    bool howBool = false;
    bool whyBool = false;
    bool correctWho = false;
    bool correctHow = false;
    bool correctWhy = false;
    Dictionary<string, string> answers = new Dictionary<string, string>();
    Dictionary<string, string> choices = new Dictionary<string, string>();
    int count = 0;
    GameObject panel;
 GameObject solveCanvas;
    void Start()
    {
        panel = GameObject.FindGameObjectWithTag("whoPanel");
    }

    public void openSolveCanvas()
    {
        if(LapTopInfo.Dat.NameList.size() ==4)
        {
        solveCanvas = GameObject.FindGameObjectWithTag("solvePanel");
        solveCanvas.GetComponent<Canvas>().sortingOrder = 1;
        }
  else if(LapTopInfo.Dat.NameList.size() !=4)
        {
        solveCanvas = GameObject.FindGameObjectWithTag("donotsolvepanel");
        solveCanvas.GetComponent<Canvas>().sortingOrder = 1;
        this.createCloseBtn(solveCanvas);

        }
        
    }

      void createCloseBtn(GameObject solveCanvas)
    {
        GameObject imgObj = Resources.Load("Prefab/CloseBtn") as GameObject;
        GameObject go = GameObject.Instantiate(imgObj);
        go.transform.SetParent(solveCanvas.transform);
        go.GetComponent<RectTransform>().anchoredPosition = new Vector3(-182f, -124f, 0);
        go.GetComponent<RectTransform>().anchorMin = new Vector2(1f, 1f);
        go.GetComponent<RectTransform>().anchorMax = new Vector2(1f, 1f);
        go.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        go.GetComponent<Button>().onClick.AddListener(delegate { lis_delete2(go); });
       
    }

     void lis_delete2(GameObject go)
    {
        //GameObject.Destroy(go.transform.parent.gameObject);
       solveCanvas.GetComponent<Canvas>().sortingOrder = -2;
    }


    public void who()
    {
        //enable all buttons
        misc._ableButtons(true, panel);
        //change text as specified
        textFile = Resources.Load<TextAsset>("Text/Choices/Who");
        setText(textFile,panel);
        whoBool = true;
        count = count + 1;
    }

    void setText(TextAsset textFile, GameObject panel)
    {
        lines = textFile.text.Split(';');
        Debug.Log("Lines" + lines.Length);
        misc.changeTextButtons(panel, lines);
    }

    public void choice()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text);
        if (whoBool) whoChoice();
        else if (howBool)howChoice();
        else if (whyBool)whyChoice();
    }

    public void finish()
    {
        if (count == 3)
        {
            endCutScene();
        }
    }

    public void whoChoice()
    {
        //store choice
        choices.Add("WHO", EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text);
        misc._ableButtons(false, panel);
        whoBool = false;
        finish();
    }

    public void how()
    {
        //enable all buttons
        misc._ableButtons(true, panel);
        //change text as specified
        textFile = Resources.Load<TextAsset>("Text/Choices/How");
        setText(textFile, panel);
        misc.changeTextButtons(panel, lines);
        howBool= true;
        count = count + 1;
    }


    public void howChoice()
    {
        //store choice
        choices.Add("HOW", EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text);
        misc._ableButtons(false, panel);
        howBool = false;
        finish();
    }


    public void why()
    {
        //enable all buttons
        misc._ableButtons(true, panel);
        //change text as specified
        textFile = Resources.Load<TextAsset>("Text/Choices/Why");
        setText(textFile, panel);
        misc.changeTextButtons(panel, lines);
        whyBool = true;
        count = count + 1;
    }


    public void whyChoice()
    {
        //store choice
        choices.Add("WHY", EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text);
        misc._ableButtons(false, panel);
        whyBool = false;
        finish();

    }

    public void obtainAnswers()
    {
        TextAsset textFile = Resources.Load<TextAsset>("Text/Answers/Who");
        answers.Add("WHO", textFile.text);
        textFile = Resources.Load<TextAsset>("Text/Answers/How");
        answers.Add("HOW", textFile.text);
        textFile = Resources.Load<TextAsset>("Text/Answers/Why");
        answers.Add("WHY", textFile.text);
            Debug.Log("WHO:" + answers["WHO"]);
            Debug.Log("HOW:" + answers["HOW"]);
            Debug.Log("WHY:" + answers["WHY"]);
        
    }

    public void compareChoicesAnswers()
    {
    
       
        if (choices["WHO"].Trim() == answers["WHO"].Trim())
        {
            Debug.Log("WHO Correct:" + choices["WHO"]);  
            correctWho = true;
        }

        if (choices["HOW"].Trim() == answers["HOW"].Trim())
        {
            Debug.Log("HOW Correct:" + choices["HOW"]);
            correctHow = true;
        }

        if (choices["WHY"].Trim() == answers["WHY"].Trim())
        {
            Debug.Log("WHY Correct:" + choices["WHY"]);
            correctWhy = true;
        }

    }

    public void endCutScene()
    {
        obtainAnswers();
        compareChoicesAnswers();

        if (correctWho && correctHow && correctWhy){
            Debug.Log("You're a great detective");
               GameObject.FindGameObjectWithTag("verdict").GetComponent<Canvas>().sortingOrder = 1;
               GameObject.FindGameObjectWithTag("verdict").GetComponentInChildren<Text>().text = "You Won";
        }

        else if (correctWho && !correctHow && !correctWhy){
            Debug.Log("At least you got the right guy");
               GameObject.FindGameObjectWithTag("verdict").GetComponent<Canvas>().sortingOrder = 1;
                     GameObject.FindGameObjectWithTag("verdict").GetComponentInChildren<Text>().text = "You Lost";
        }

        else if (correctWho && correctHow && !correctWhy){
            Debug.Log("Almost there");
               GameObject.FindGameObjectWithTag("verdict").GetComponent<Canvas>().sortingOrder = 1;
                     GameObject.FindGameObjectWithTag("verdict").GetComponentInChildren<Text>().text = "You Lost";
        }

        else if (correctWho && !correctHow && correctWhy){
            Debug.Log("Almost there");
               GameObject.FindGameObjectWithTag("verdict").GetComponent<Canvas>().sortingOrder = 1;
                     GameObject.FindGameObjectWithTag("verdict").GetComponentInChildren<Text>().text = "You Lost";
        }

        else 
            Debug.Log("Try again");
    }
}
