using UnityEngine;
using System.Collections;

public class PBSceneCouchBook
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneCouchBook();
        cm.placing(d, popUp, sceneBool);
    }
}
