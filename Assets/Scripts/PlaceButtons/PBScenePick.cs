using UnityEngine;
using System.Collections;

public class PBScenePick {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBScenePick();
        cm.placing(d, popUp, sceneBool);
    }
}
