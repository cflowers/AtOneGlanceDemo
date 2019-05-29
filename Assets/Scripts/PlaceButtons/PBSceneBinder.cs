using UnityEngine;
using System.Collections;

public class PBSceneBinder {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneBinder();
        cm.placing(d, popUp, sceneBool);
    }
}
