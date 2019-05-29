using UnityEngine;
using System.Collections;

public class PBSceneFork {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFork();
        cm.placing(d, popUp, sceneBool);
    }
}
