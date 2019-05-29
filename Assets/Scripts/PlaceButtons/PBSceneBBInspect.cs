using UnityEngine;
using System.Collections;

public class PBSceneBBInspect
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneBBInspect();
        cm.placing(d, popUp, sceneBool);
    }
}
