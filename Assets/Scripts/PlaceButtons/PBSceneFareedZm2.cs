using UnityEngine;
using System.Collections;

public class PBSceneFareedZm2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFareedZm2();
        cm.placing(d, popUp, sceneBool);
    }
}
