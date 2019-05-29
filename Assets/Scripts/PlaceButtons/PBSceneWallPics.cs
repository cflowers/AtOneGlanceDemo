using UnityEngine;
using System.Collections;

public class PBSceneWallPic {

    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneWallPics();
        cm.placing(d, popUp, sceneBool);
    }
}
