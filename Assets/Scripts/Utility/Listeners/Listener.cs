using UnityEngine;
using UnityEngine.SceneManagement;

public class Listener : MonoBehaviour {

    public void laptopScene()
    {
          
        SceneManager.LoadSceneAsync("LapTop");
    }

    public void levelOne()
    {
        LapTopInfo.Dat.saveNotes();
        LapTopInfo.Dat.saveSuspects();
        SceneManager.LoadSceneAsync("Level1");
    }

   
}
