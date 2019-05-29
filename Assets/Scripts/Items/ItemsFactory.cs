using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public interface ItemsFactory
{
    void beginText();
    void loadImage();
    void setItemDesc(string itemDesc);
    void loadTextFile(string path);
    void parseText();
    string getTextFile();
    string[] getText();
    bool getWrite();
    void loadPic(string path);
    Texture2D getPic();
   

   
}
