using UnityEngine;
using System.Collections;

public class PBSceneFPMessPaper2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPMessPaper2();
        cm.placing(d, popUp, sceneBool);
    }
}
