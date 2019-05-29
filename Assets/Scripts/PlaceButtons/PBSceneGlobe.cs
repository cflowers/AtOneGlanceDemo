using UnityEngine;
using System.Collections;

public class PBSceneGlobe {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneGlobe();
        cm.placing(d, popUp, sceneBool);
    }
}
