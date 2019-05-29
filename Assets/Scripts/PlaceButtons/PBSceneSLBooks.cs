using UnityEngine;
using System.Collections;

public class PBSceneSLBooks {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneSLBooks();
        cm.placing(d, popUp, sceneBool);
    }
}
