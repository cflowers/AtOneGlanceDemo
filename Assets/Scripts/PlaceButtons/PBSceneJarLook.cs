using UnityEngine;
using System.Collections;

public class PBSceneJarLook {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneJarLook();
        cm.placing(d, popUp, sceneBool);
    }
}
