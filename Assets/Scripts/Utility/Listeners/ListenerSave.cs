using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class ListenerSave : MonoBehaviour {

    public void openWindow()
    {
        //show save window
        Scene_GettingObjs.getObjs().SaveWindow.GetComponent<Canvas>().enabled = true;
        Scene_GettingObjs.getObjs().LoadWindow.GetComponent<Canvas>().enabled = false;
    }

    public void save()
    {
        PlayerInfo.Name = obtainName().text;//get and set name
        PlayerInfo.NewGame = false;
        savePlayerInfo();//save player information
        saveLapTopInfo();  //save laptop information
        Scene_GettingObjs.getObjs().SaveWindow.GetComponent<Canvas>().enabled = false;
    }

    //map name with playerInfo.dat and laptopInfo.dat
    //put it in the right path(Application.PersistentPath/name/player.dat and laptop.dat
    void savePlayerInfo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        System.IO.Directory.CreateDirectory(Application.persistentDataPath + "/" + PlayerInfo.Name);
        FileStream file = File.Create(Application.persistentDataPath + "/"+PlayerInfo.Name +"/playerInfo.dat");
        PlayerData playerDat = new PlayerData();
        playerDat.saveName();
        playerDat.saveItems();
        playerDat.savePoints();
        playerDat.saveInspection();
        playerDat.saveNewGame();
        playerDat.saveBadges();
        bf.Serialize(file, playerDat);
        file.Close();
    }

    void saveLapTopInfo()
    {
        Debug.Log("Dat file Namelist:" + LapTopInfo.Dat.NameList.size());
        Debug.Log("Dat file Notes:" + LapTopInfo.Dat.Notes.size());
        Debug.Log("Dat file Map:" + LapTopInfo.Dat.Map.Count);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream savefile = File.Create(Application.persistentDataPath + "/" + PlayerInfo.Name + "/laptopInfo.dat");
        bf.Serialize(savefile, LapTopInfo.Dat);
        savefile.Close();
    }

    Text obtainName()
    {
        Text[] textFields = Scene_GettingObjs.getObjs().SaveWindow.GetComponentsInChildren<Text>();
        Text name=null;
        for (int i = 0; i < textFields.Length; i++)
        {
            if (textFields[i].CompareTag("saveName") == true)
            {
                Debug.Log("Save Name");
                name = textFields[i];
                break;
            }
        }
        return name;
    }
   
}
