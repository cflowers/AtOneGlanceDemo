using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneWineGlassE
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneWineGlassE();
        cm.placing(d, popUp, sceneBool);
    }


}

