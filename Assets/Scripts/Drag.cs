using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{

    public void DragStuff()
    {
        Debug.Log(Input.mousePosition);
        GameObject.FindGameObjectWithTag("node").transform.position = Input.mousePosition;
    }

    public void onClickStuff()
    {


    }

}
