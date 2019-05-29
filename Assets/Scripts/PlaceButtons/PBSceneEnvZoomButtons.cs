using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneEnvZoomButtons
{
    public void sceneEnvZoomButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneEnvZoom();
        cm.placing(d, popUp, sceneBool);
    }


}

