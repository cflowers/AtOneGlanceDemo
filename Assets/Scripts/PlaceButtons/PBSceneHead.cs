using UnityEngine;
using System.Collections;

public class PBSceneHead {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneHead();
        cm.placing(d, popUp, sceneBool);
    }
}
