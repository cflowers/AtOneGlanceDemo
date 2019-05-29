using UnityEngine;
using System.Collections;

public class PBSceneBBookCaseUp
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneBBookCaseUp();
        cm.placing(d, popUp, sceneBool);
    }
}
