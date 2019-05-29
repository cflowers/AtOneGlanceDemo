using UnityEngine;
using System.Collections;

public class PBSceneAwardZoom {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneAwardZoom();
        cm.placing(d, popUp, sceneBool);
    }
}
