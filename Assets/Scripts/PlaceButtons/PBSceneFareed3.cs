using UnityEngine;
using System.Collections;

public class PBSceneFareed3
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFareed3();
        cm.placing(d, popUp, sceneBool);
    }
}
