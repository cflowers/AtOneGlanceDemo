using UnityEngine;
using System.Collections;

public class PBSceneFareedZm3
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFareedZm3();
        cm.placing(d, popUp, sceneBool);
    }
}
