using UnityEngine;
using System.Collections;

public class PBSceneDad2
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneDad2();
        cm.placing(d, popUp, sceneBool);
    }
}
