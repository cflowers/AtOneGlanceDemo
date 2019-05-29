using UnityEngine;
using System.Collections;

public class PBSceneCup {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneCup();
        cm.placing(d, popUp, sceneBool);
    }
}
