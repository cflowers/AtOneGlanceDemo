using UnityEngine;
using System.Collections;

public class PBSceneCouchCD
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneCouchCD();
        cm.placing(d, popUp, sceneBool);
    }
}
