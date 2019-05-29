using UnityEngine;
using System.Collections;

public class PBSceneFPPicL
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPPicL();
        cm.placing(d, popUp, sceneBool);
    }
}
