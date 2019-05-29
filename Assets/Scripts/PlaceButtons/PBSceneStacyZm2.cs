using UnityEngine;
using System.Collections;

public class PBSceneStacyZm2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneStacyZm2();
        cm.placing(d, popUp, sceneBool);
    }
}
