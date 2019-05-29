using UnityEngine;
using System.Collections;

public class PBScenePurpleBookCase
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBScenePurpleBookCase();
        cm.placing(d, popUp, sceneBool);
    }
}
