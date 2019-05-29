using UnityEngine;
using System.Collections;

public class PBSceneBlueBookCase
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneBlueBookCase();
        cm.placing(d, popUp, sceneBool);
    }
}
