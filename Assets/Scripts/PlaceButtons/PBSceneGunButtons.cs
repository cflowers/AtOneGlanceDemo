using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneGunButtons
{
    public void sceneGunButtons(Done d,Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneGun();
        cm.placing(d, popUp, sceneBool);
    }


}

