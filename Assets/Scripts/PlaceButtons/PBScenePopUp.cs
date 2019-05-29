using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBScenePopUp
{

    public void scenePopUpButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBScenePopUp();
        cm.placing(d, popUp, sceneBool);
    }



}

