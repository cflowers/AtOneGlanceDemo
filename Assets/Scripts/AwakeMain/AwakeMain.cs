using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

/**
 * Game starts here
 */ 
public class AwakeMain : MonoBehaviour {
 
    void Awake()
    {
        //display PlayerInfo
        //Load Items int Json Object
        using (StreamReader r = new StreamReader("Assets/Resources/Text/Json/Items.json"))
        {
            JsonBuffer.jsonString = r.ReadToEnd();
        }
        JsonBuffer.jsonItems = new JSONItem[5];
        JsonBuffer.jsonItems = JsonHelper.FromJson<JSONItem>(JsonBuffer.jsonString);

        //disable toggles in notebook
        GameObject notebookToggle = Scene_GettingObjs.getObjs().NotebookToggle;
        Misc misc = new Misc();
        misc._ableToggles(notebookToggle, false);
        
    }

   
}
