using UnityEngine;
using System.Collections;

public class PBSceneHand
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneHand();
        cm.placing(d, popUp, sceneBool);
    }
}
