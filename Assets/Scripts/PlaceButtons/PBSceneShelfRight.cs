using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneShelfRight
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneShelfRight();
        cm.placing(d, popUp, sceneBool);
    }


}

