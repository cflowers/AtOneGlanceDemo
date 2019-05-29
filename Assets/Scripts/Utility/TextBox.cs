using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBox : MonoBehaviour {

    public bool textBool = false;
    public bool enableDone = false;
    bool disableDone = true;
   
	void Update () {
       
        if (textBool && !enableDone)
            showTextBoxScroll();

        else if(!textBool && !disableDone)
            disableTextBoxScroll();
	}

    void showTextBoxScroll()
    {
       // Debug.Log("Show Text Box Scroll");
        GameObject textBox = GameObject.FindGameObjectWithTag("scrollbox");
        GameObject scrollVert = GameObject.FindGameObjectWithTag("scrollVert");
        textBox.GetComponentInChildren<RawImage>().enabled = true;
        textBox.GetComponentInChildren<Text>().enabled = true;
        Image[] images2 = scrollVert.GetComponentsInChildren<Image>();
        Image[] images = textBox.GetComponentsInChildren<Image>();
        foreach (Image i in images)
        {
            i.enabled = true;
        }
        
        foreach (Image i in images2)
        {
            i.enabled = true;
        }
        textBox.GetComponent<RectTransform>().anchoredPosition = new Vector2(-38, 160);
        textBox.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0f);
        textBox.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0f);
        textBox.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        scrollVert.GetComponent<RectTransform>().anchoredPosition = new Vector2(-182, 159);
        scrollVert.GetComponent<RectTransform>().anchorMin = new Vector2(1f, 0f);
        scrollVert.GetComponent<RectTransform>().anchorMax = new Vector2(1f, 0f);
        scrollVert.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        enableDone = true;
        disableDone = false;

    }

    void disableTextBoxScroll()
    {
       // Debug.Log("Disable Text Box Scroll");
        GameObject textBox = GameObject.FindGameObjectWithTag("scrollbox");
        GameObject scrollVert = GameObject.FindGameObjectWithTag("scrollVert");
        Image[] images2 = scrollVert.GetComponentsInChildren<Image>();
        textBox.GetComponentInChildren<RawImage>().enabled = false;
        textBox.GetComponentInChildren<Text>().enabled = false;
        Image[] images = textBox.GetComponentsInChildren<Image>();
        foreach (Image i in images)
        {
            i.enabled = false;
        }
        foreach (Image i in images2)
        {
            i.enabled = false;
        }
        enableDone = false;
        disableDone = true;
    }


    void showTextBox()
    {
        GameObject textBox = GameObject.FindGameObjectWithTag("textBox");
        textBox.GetComponent<Image>().enabled = true;
        GameObject panelText = GameObject.FindGameObjectWithTag("panelText");
        panelText.GetComponent<Text>().enabled = true;
        //  GetComponentInChildren<Text>().enabled = true;
        GameObject panelBtn = GameObject.FindGameObjectWithTag("panelBtn");
        panelBtn.GetComponent<Image>().enabled = true;
        panelBtn.GetComponent<Button>().enabled = true;
        textBox.GetComponent<RectTransform>().anchoredPosition = new Vector2(-38, 109);
        textBox.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0f);
        textBox.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0f);
        textBox.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
        panelText.GetComponent<Text>().GetComponent<RectTransform>().anchoredPosition = new Vector2(531, 130);
        panelText.GetComponent<Text>().GetComponent<RectTransform>().anchorMin = new Vector2(0f, 0f);
        panelText.GetComponent<Text>().GetComponent<RectTransform>().anchorMax = new Vector2(0f, 0f);
        panelText.GetComponent<Text>().GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);

    }

    void disableTextBox()
    {
        GameObject textBox = GameObject.FindGameObjectWithTag("textBox");
        textBox.GetComponent<Image>().enabled = false;
        //GetComponentInChildren<Text>().enabled = false;
        GameObject panelText = GameObject.FindGameObjectWithTag("panelText");
        panelText.GetComponent<Text>().enabled = false;
        GameObject panelBtn = GameObject.FindGameObjectWithTag("panelBtn");
        panelBtn.GetComponent<Image>().enabled = false;
        panelBtn.GetComponent<Button>().enabled = false;
    }

   
}

