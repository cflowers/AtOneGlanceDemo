using UnityEngine;
using System.Collections;

public class PBSceneFP {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFP();
        cm.placing(d, popUp, sceneBool);
    }
}
