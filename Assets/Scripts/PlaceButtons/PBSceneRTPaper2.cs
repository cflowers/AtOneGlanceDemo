using UnityEngine;
using System.Collections;

public class PBSceneRTPaper2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneRTPaper2();
        cm.placing(d, popUp, sceneBool);
    }
}
