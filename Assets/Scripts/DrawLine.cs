using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class DrawLine : MonoBehaviour
{

    bool connected = false;
    public Camera cam;
    private LinkedList<Transform> list = new LinkedList<Transform>();
  

	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            updateHelper_drawLines();
        }

      
	}

   

    private void updateHelper_drawLines()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "node")
            {
                addPoint(hit.transform);
                connect();

            }
            removeElements();
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
            GameObject line = Resources.Load("Prefab/Line") as GameObject;
            GameObject bufLine = GameObject.Instantiate(line);
            bufLine.GetComponent<LineRenderer>().SetWidth(.45f, .45f);
            bufLine.GetComponent<LineRenderer>().SetPosition(0, list.First.Value.position);
            bufLine.GetComponent<LineRenderer>().SetPosition(1, list.Last.Value.position);
            connected = true;
        }

    }

    private void removeElements()
    {
        if (connected){
            int size = list.Count;
            for (int i = 0; i < size; i++)
               {
                    list.RemoveFirst();
               }
        }
            connected = false;
     }
    
}
