using UnityEngine;
using System.Collections;

public class PBSceneDadZm2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneDadZm2();
        cm.placing(d, popUp, sceneBool);
    }
}
