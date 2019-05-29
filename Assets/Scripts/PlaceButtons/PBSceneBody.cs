using UnityEngine;
using System.Collections;

public class PBSceneBody
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneBody();
        cm.placing(d, popUp, sceneBool);
    }
}
