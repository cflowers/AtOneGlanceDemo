using UnityEngine;
using System.Collections;

public class PBSceneFPMess
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPMess();
        cm.placing(d, popUp, sceneBool);
    }
}
