using UnityEngine;
using System.Collections;

public class PBSceneStacyZm
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneStacyZm();
        cm.placing(d, popUp, sceneBool);
    }
}
