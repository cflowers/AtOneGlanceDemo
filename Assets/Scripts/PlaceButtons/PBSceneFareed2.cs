using UnityEngine;
using System.Collections;

public class PBSceneFareed2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFareed2();
        cm.placing(d, popUp, sceneBool);
    }
}
