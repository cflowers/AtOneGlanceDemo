using UnityEngine;
using System.Collections;

public class PBSceneAnthraxBook {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneAnthraxBook();
        cm.placing(d, popUp, sceneBool);
    }
}
