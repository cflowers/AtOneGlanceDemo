using UnityEngine;
using System.Collections;

public class PBSceneBroom {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneBroom();
        cm.placing(d, popUp, sceneBool);
    }
}
