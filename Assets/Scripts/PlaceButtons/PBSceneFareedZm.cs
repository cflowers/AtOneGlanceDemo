using UnityEngine;
using System.Collections;

public class PBSceneFareedZm
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFareedZm();
        cm.placing(d, popUp, sceneBool);
    }
}
