using UnityEngine;
using System.Collections;

public class PBSceneTiger {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneTiger();
        cm.placing(d, popUp, sceneBool);
    }
}
