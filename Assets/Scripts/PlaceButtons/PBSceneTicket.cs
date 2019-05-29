using UnityEngine;
using System.Collections;

public class PBSceneTicket {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneTicket();
        cm.placing(d, popUp, sceneBool);
    }
}
