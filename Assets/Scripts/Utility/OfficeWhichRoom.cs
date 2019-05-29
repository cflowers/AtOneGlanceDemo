using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OfficeWhichRoom
{
    public bool atComp = true;
    public bool onComp = false;
    public Dictionary<string, bool> map = new Dictionary<string, bool>();

       public void fillMap()
       {
           map.Add("AT_COMP", true);
           map.Add("ON_COMP", false);
       }

    public void boolHandle(string name)
    {
        // Debug.Log("Name:" + name);
        List<string> keys = new List<string>(map.Keys);

        foreach (string key in keys)
        {
            if (key == name)
                map[key] = true;
            else
                map[key] = false;
        }
    }
   
}
