using UnityEngine;
using System.Collections;

public class PBSceneRoundTable
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneRoundTable();
        cm.placing(d, popUp, sceneBool);
    }
}
