using UnityEngine;
using System.Collections;

public class PBSceneDadPic {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneDadPic();
        cm.placing(d, popUp, sceneBool);
    }
}
