using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneWineBottle
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneWineBottle();
        cm.placing(d, popUp, sceneBool);
    }


}

