using UnityEngine;
using System.Collections;

public class PBSceneShelfLeft {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneShelfLeft();
        cm.placing(d, popUp, sceneBool);
    }
}
