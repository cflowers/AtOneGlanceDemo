using UnityEngine;
using System.Collections;

public class PBSceneFPMessPaper1
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPMessPaper1();
        cm.placing(d, popUp, sceneBool);
    }
}
