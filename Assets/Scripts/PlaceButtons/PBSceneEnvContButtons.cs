using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneEnvContButtons
{
    public void sceneEnvContButtons(Done d,Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneEnvCont();
        cm.placing(d, popUp, sceneBool);
    }


}

