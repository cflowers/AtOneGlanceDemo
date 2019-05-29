using UnityEngine;
using System.Collections;

public class PBScenePContacts {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBScenePContacts();
        cm.placing(d, popUp, sceneBool);
    }
}
