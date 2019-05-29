using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneWineGlassF
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneWineGlassF();
        cm.placing(d, popUp, sceneBool);
    }


}

