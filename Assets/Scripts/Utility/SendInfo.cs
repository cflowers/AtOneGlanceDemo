using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SendInfo : MonoBehaviour {

    string name;
    RawImage img;

    public string getName()
    {
        return this.name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setImg(RawImage img)
    {
        this.img = img;
    }



}
