using UnityEngine;
using System.Collections;

public class PBSceneRTPapers
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneRTPapers();
        cm.placing(d, popUp, sceneBool);
    }
}
