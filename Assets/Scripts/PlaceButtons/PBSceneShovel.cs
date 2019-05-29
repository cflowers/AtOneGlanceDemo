using UnityEngine;
using System.Collections;

public class PBSceneShovel {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneShovel();
        cm.placing(d, popUp, sceneBool);
    }
}
