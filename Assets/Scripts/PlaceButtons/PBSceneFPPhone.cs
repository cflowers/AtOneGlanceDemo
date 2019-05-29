using UnityEngine;
using System.Collections;

public class PBSceneFPPhone
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPPhone();
        cm.placing(d, popUp, sceneBool);
    }
}
