using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ListenerLoad : MonoBehaviour {

    string[] dirs;
    GameObject loadName;
    CFLinkedList<GameObject> listObjs;
    GameObject prefabButton;
    GameObject loadPanel;
    float yPos = 187f;

    void Start()
    {
        loadName  = GameObject.FindGameObjectWithTag("loadName");
        loadPanel = GameObject.FindGameObjectWithTag("loadPanel");
        listObjs  = new CFLinkedList<GameObject>();
        prefabButton = Resources.Load("Prefab/LoadButtons") as GameObject;
        yPos = 187f;
    }

    public void openWindow()
    {
        yPos = 187f;
        //show load window
        Scene_GettingObjs.getObjs().LoadWindow.GetComponent<Canvas>().enabled = true;
        dirs = System.IO.Directory.GetDirectories(Application.persistentDataPath);
        for(int i = 0; i < dirs.Length; i++)
        {
            //Debug.Log("Dirs:" + dirs[i]);
            //Debug.Log("Dirs:" + dirs[i].IndexOf('\\'));
            //Debug.Log(dirs[i].Substring(index + 1));
            int index = dirs[i].IndexOf('\\');
            instantiateLoadButton(i, index);   
        }
       
    }

    void instantiateLoadButton(int i, int index)
    {
        GameObject bufButton = GameObject.Instantiate(prefabButton);
        bufButton.transform.SetParent(loadPanel.transform, false);
        bufButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, yPos);
        yPos = yPos - bufButton.GetComponent<RectTransform>().sizeDelta.y;
        bufButton.GetComponentInChildren<Text>().text = dirs[i].Substring(index + 1);
        bufButton.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate { load(bufButton); }));
        listObjs.Add(bufButton);
    }

    public void load(GameObject button)
    {
        GameObject b = listObjs.getList().Find(button).Value;
        Debug.Log(b.GetComponentInChildren<Text>().text);
        loadName.GetComponentInChildren<Text>().text = b.GetComponentInChildren<Text>().text;
    }


    public void loadInLevel()
    {

            loadPlayerInfo(loadName); //save player information
            loadLapTopInfo(loadName);  //save laptop information
            Scene_GettingObjs.getObjs().LoadWindow.GetComponent<Canvas>().enabled = false;
            destroyButtons();
    }


    //map name with playerInfo.dat and laptopInfo.dat
    //put it in the right path(Application.PersistentPath/name/player.dat and laptop.dat
    void loadPlayerInfo(GameObject loadName)
    {
         BinaryFormatter bf = new BinaryFormatter();
         Debug.Log("Path:" + Application.persistentDataPath + "/" + loadName.GetComponentInChildren<Text>().text + "/playerInfo.dat");
         FileStream file = File.Open(Application.persistentDataPath + "/" + loadName.GetComponentInChildren<Text>().text + "/playerInfo.dat", FileMode.Open);
         PlayerData playerDat = (PlayerData)bf.Deserialize(file);
         file.Close();
         LoadInfo loadInfo = new LoadInfo();
         loadInfo.loadPlayerInfo(playerDat);
    }

    void loadLapTopInfo(GameObject loadName)
    {
        if (File.Exists(Application.persistentDataPath + "/" + loadName.GetComponentInChildren<Text>().text +"/laptopInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/" + loadName.GetComponentInChildren<Text>().text + "/laptopInfo.dat", FileMode.Open);
            LapTopData dat = (LapTopData)bf.Deserialize(file);
            Debug.Log("Dat file Notes:" + dat.Notes.size());
            LapTopInfo.Dat = dat;
            LapTopInfo.ListSaveNotes = LapTopInfo.Dat.Notes;
           
            file.Close();
        }
    }


    void destroyButtons()
    {
        if (listObjs.size() > 0)
        {
            for (int i = 0; i < listObjs.size(); i++)
            {
                GameObject.Destroy(listObjs.get(i));
                listObjs.get(i);
            }
        }
    }
   
}
