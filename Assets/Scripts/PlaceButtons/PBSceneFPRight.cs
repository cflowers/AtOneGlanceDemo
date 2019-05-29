using UnityEngine;
using System.Collections;

public class PBSceneFPRight {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPRight();
        cm.placing(d, popUp, sceneBool);
    }
}
