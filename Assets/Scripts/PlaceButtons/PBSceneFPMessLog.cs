using UnityEngine;
using System.Collections;

public class PBSceneFPMessLog
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPMessLog();
        cm.placing(d, popUp, sceneBool);
    }
}
