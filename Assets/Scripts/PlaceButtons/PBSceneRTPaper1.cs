using UnityEngine;
using System.Collections;

public class PBSceneRTPaper1
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneRTPaper1();
        cm.placing(d, popUp, sceneBool);
    }
}
