using UnityEngine;
using System.Collections;

public class PBSceneGreenBookCase
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneGreenBookCase();
        cm.placing(d, popUp, sceneBool);
    }
}
