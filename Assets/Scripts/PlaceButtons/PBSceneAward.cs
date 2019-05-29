using UnityEngine;
using System.Collections;

public class PBSceneAward {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneAward();
        cm.placing(d, popUp, sceneBool);
    }
}
