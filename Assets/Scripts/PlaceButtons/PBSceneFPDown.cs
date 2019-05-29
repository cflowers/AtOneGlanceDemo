using UnityEngine;
using System.Collections;

public class PBSceneFPDown
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPDown();
        cm.placing(d, popUp, sceneBool);
    }
}
