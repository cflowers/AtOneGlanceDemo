using UnityEngine;
using System.Collections;

public class PBSceneFPBoomBox
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPBoomBox();
        cm.placing(d, popUp, sceneBool);
    }
}
