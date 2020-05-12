using UnityEngine;
using System.Collections;

public class PBSceneTicket2 {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneTicket2();
        cm.placing(d, popUp, sceneBool);
    }
}
