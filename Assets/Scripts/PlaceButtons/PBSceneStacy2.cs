using UnityEngine;
using System.Collections;

public class PBSceneStacy2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneStacy2();
        cm.placing(d, popUp, sceneBool);
    }
}
