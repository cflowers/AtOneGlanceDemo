using UnityEngine;
using System.Collections;

public class PBSceneStacy
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneStacy();
        cm.placing(d, popUp, sceneBool);
    }
}
