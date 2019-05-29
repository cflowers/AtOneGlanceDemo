using UnityEngine;
using System.Collections;

public class PBSceneGContacts {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneGContacts();
        cm.placing(d, popUp, sceneBool);
    }
}
