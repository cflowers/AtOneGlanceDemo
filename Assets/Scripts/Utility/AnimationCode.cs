using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimationCode : MonoBehaviour
{

    float picRate_Sec = 0.03f;
    Texture2D[] pics;
    float nextPic = 0f;
    int counter1 = 0;
    RawImage rawImageComp;
    public bool beginAnimation1 = false;
    int countFalse = 0;

    public void beginAnimation(RawImage rawImageComp, string fileName)
    {
        pics = Resources.LoadAll<Texture2D>(fileName);
        this.rawImageComp = rawImageComp;
        beginAnimation1 = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (beginAnimation1 == true && Time.time > nextPic)
        {
            countFalse = 0;
            rawImageComp.enabled = true;
            animateTextures();

        }

        else if (beginAnimation1 == false && countFalse ==0)
        {
            rawImageComp.enabled = false;
            countFalse = countFalse + 1;
        }
       
    }

    void animateTextures()
    {
        nextPic = Time.time + picRate_Sec;
        if (counter1 < pics.Length)
        {
            rawImageComp.texture = pics[counter1];
            counter1 += 1;
        }

        else if (counter1 >= pics.Length)
        {
            if (true)
                counter1 = 0;
        }
    }

}
