using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopUpLis : MonoBehaviour {

    public Canvas canvas;
   
    GameObject obj;
    GameObject hud_points;
	
	void Start () {
        hud_points = GameObject.FindGameObjectWithTag("points");
        hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
	}
	
	void Update () {
       
           
	
	}

    public void setG(GameObject obj)
    {
        this.obj = obj;
    }

    public void close()
    {
        canvas.enabled = false;
    }

    public void lis_yes()
    {
        this.obj.SetActive(false);
        canvas.enabled = false;
        int points = PlayerInfo.Points;
        PlayerInfo.Points = points - 2;
        hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
    }

    public void lis_no()
    {
        canvas.enabled = false;
    }
}
