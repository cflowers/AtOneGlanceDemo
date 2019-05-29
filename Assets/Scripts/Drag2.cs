using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Drag2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

   
    private GameObject obj;
    private LinkedList<Transform> list = new LinkedList<Transform>();
    bool connected = false;
    public Transform parent;
    public LoadNotes ln;


    void Start()
    {
        GameObject lisObj = GameObject.FindGameObjectWithTag("listenerObj");
        ln = lisObj.GetComponent<LoadNotes>();
    }

    public void OnPointerDown(PointerEventData ped) {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(ped.pointerCurrentRaycast.gameObject.name);
            
         //   Debug.Log(ln.getPlaceHolders()[0].go.name);
            obj = ped.pointerCurrentRaycast.gameObject;
        }

        else if (Input.GetMouseButtonDown(1))
        {
            obj = ped.pointerCurrentRaycast.gameObject;
           // addPoint(obj.transform);
        }
     
    }
	
	public void OnPointerUp(PointerEventData ped) {
        if (Input.GetMouseButtonUp(0))
        {
           
            obj.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            
        }

        else if (Input.GetMouseButtonUp(1))
        {
            forcePlacement();
            connect();
        }
    }

    private void forcePlacement()
    {
    //    if(obj.name == ln.getPlaceHolders()[0].go.name
        if (Input.mousePosition.x == ln.getPlaceHolders()[0].position.x 
            || Input.mousePosition.x > ln.getPlaceHolders()[0].position.x -20
            ||Input.mousePosition.x < ln.getPlaceHolders()[0].position.x + 20
            )

        {
            obj.transform.position = ln.getPlaceHolders()[0].position;
        }
    }

    private void addPoint(Transform elem)
    {
        if (list.Count < 2)
        {
            list.AddLast(elem);
        }
    }

    private void connect()
    {
        if (list.Count == 2)
        {
            Vector3 pointA = list.First.Value.localPosition;
            Vector3 pointB = list.Last.Value.localPosition;
            Vector3 unitVec = pointB - pointA;


            GameObject line = Resources.Load("Prefab/CanvasLine") as GameObject;
            
            GameObject bufLine = (GameObject)Object.Instantiate(line, Vector3.zero, Quaternion.identity);
            bufLine.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
            bufLine.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            bufLine.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            bufLine.GetComponent<LineRenderer>().SetWidth(45f, 45f);
            Debug.Log("Raw Image:" + list.First.Value.localPosition);
            bufLine.GetComponent<LineRenderer>().SetPosition(0, list.First.Value.localPosition);
            bufLine.GetComponent<LineRenderer>().SetPosition(1, list.Last.Value.localPosition);
            bufLine.transform.SetParent(parent);
            connected = true;
        }

    }

    private void removeElements()
    {
        if (connected)
        {
            int size = list.Count;
            for (int i = 0; i < size; i++)
            {
                list.RemoveFirst();
            }
        }
        connected = false;
    }
}
