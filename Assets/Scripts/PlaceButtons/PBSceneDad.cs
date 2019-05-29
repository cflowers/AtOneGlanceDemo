using UnityEngine;
using System.Collections;

public class PBSceneDad
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneDad();
        cm.placing(d, popUp, sceneBool);
    }
}
