using UnityEngine;
using System.Collections;

public class PBSceneDadZm
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneDadZm();
        cm.placing(d, popUp, sceneBool);
    }
}
