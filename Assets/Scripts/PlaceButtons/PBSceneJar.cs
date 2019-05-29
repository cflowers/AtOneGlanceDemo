using UnityEngine;
using System.Collections;

public class PBSceneJar {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneJar();
        cm.placing(d, popUp, sceneBool);
    }
}
