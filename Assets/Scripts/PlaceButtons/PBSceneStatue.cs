using UnityEngine;
using System.Collections;

public class PBSceneStatue {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneStatue();
        cm.placing(d, popUp, sceneBool);
    }
}
