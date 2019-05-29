using UnityEngine;
using System.Collections;

public class PBSceneFPLeft {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPLeft();
        cm.placing(d, popUp, sceneBool);
    }
}
