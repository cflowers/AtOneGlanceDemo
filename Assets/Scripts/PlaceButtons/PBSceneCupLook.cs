using UnityEngine;
using System.Collections;

public class PBSceneCupLook {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneCupLook();
        cm.placing(d, popUp, sceneBool);
    }
}
