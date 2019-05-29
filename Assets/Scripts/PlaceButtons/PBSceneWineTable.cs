using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneWineTable
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneWineTable();
        cm.placing(d, popUp, sceneBool);
    }


}

