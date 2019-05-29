using UnityEngine;
using System.Collections;

public class PBSceneFPPicR
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPPicR();
        cm.placing(d, popUp, sceneBool);
    }
}
