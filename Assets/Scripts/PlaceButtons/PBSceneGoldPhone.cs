using UnityEngine;
using System.Collections;

public class PBSceneGoldPhone
{

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneGoldPhone();
        cm.placing(d, popUp, sceneBool);
    }
}
