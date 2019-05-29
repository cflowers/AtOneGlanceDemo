using UnityEngine;
using System.Collections;

public class PBSceneCouch
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneCouch();
        cm.placing(d, popUp, sceneBool);
    }
}
