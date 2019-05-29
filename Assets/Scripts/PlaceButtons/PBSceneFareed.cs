using UnityEngine;
using System.Collections;

public class PBSceneFareed
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFareed();
        cm.placing(d, popUp, sceneBool);
    }
}
