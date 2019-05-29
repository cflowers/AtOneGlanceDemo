using UnityEngine;
using System.Collections;

public class PBSceneCouchPillow
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneCouchPillow();
        cm.placing(d, popUp, sceneBool);
    }
}
