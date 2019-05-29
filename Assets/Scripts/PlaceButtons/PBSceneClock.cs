using UnityEngine;
using System.Collections;

public class PBSceneClock {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneClk();
        cm.placing(d, popUp, sceneBool);
    }
}
