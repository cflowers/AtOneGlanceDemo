using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PBSceneFPLetter
{
    public void sceneButtons(Done d, Done popUp, bool sceneBool)
    {
        CreateButtonFactory cm = new CBSceneFPLetter();
        cm.placing(d, popUp, sceneBool);
    }



}

