﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[Serializable]
public abstract class AbstractItems : ItemsFactory
{
    [System.NonSerialized]
    public TextAsset textFile;
     [System.NonSerialized]
    public Texture2D img;
    string[] lines;
    public string itemDesc;
    

    public virtual void beginText() { }

    public virtual void loadImage() { }

    public virtual bool getWrite() { return false; }

    public virtual void setItemDesc(string itemDesc) { this.itemDesc = itemDesc; }

    public void begin(string path) {
        loadTextFile(path);
        parseText();
    }

    public void loadTextFile(string path)
    {
        textFile = Resources.Load<TextAsset>(path);
       // Debug.Log(textFile.name);

    }

    public void loadPic(string path)
    {
        img = Resources.Load<Texture2D>(path);
       // Debug.Log(img);
    }

    public void parseText()
    {
       
        lines = textFile.text.Split('\n');
    //    Debug.Log(lines.Length);

    }

    public string getTextFile()
    {
        string text = "";
        if (textFile != null)
            text = textFile.text;
        return text;
    }

    public string[] getText()
    {
        return lines;
    }

    public Texture2D getPic()
    {
        return img;
    }
  
}