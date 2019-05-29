using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneFPMap
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPMap();
        cm.placing(d, popUp, sceneBool);
    }



}

