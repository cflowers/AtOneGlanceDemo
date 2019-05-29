using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlaceHolder
{
    public GameObject go;
    public Vector2 position;

    public PlaceHolder(GameObject go, Vector2 position)
    {
        this.go = go;
        this.position = position;
    }

}