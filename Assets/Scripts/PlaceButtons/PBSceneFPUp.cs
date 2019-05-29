using UnityEngine;
using System.Collections;

public class PBSceneFPUp
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPUp();
        cm.placing(d, popUp, sceneBool);
    }
}
