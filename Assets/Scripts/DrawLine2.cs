using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DrawLine2 : MonoBehaviour {

    Vector2 pointA;//(0,4)
    Vector2 pointB;//(204,60)
    RectTransform imageRectTransform;
    public RawImage raw1;
    public RawImage raw2;
    float raw1_width;


	void Start () {
        pointA = raw1.rectTransform.anchoredPosition;//(0,4)
        raw1_width = raw1.rectTransform.sizeDelta.x;//(100)
        pointB = raw2.rectTransform.anchoredPosition;//(204,60)
        
        imageRectTransform = gameObject.GetComponent<RectTransform>();
        Vector3 differenceVector = pointB - pointA;//(204,56)
        //Vector3 = UnitVec*(differenceVector + width)
        Debug.Log(differenceVector.magnitude);//211.54
        //Get direction
        Vector3 unitVec = Vector3.Normalize(pointB - pointA);//(1,0.3,0)
        Debug.Log("Normalize" + unitVec);
        imageRectTransform.sizeDelta = new Vector2(differenceVector.magnitude, 30f);//(211.54,45)
      //  Vector3 vec = new Vector3(unitVec.x * (differenceVector.x + raw1_width), (differenceVector.y), 0);
        Vector3 vec = new Vector3((differenceVector.x - raw1_width), (differenceVector.y), 0);
        imageRectTransform.anchoredPosition = vec;
        imageRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        imageRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        imageRectTransform.pivot = new Vector2(0.5f, 0.5f);
        float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
        imageRectTransform.rotation = Quaternion.Euler(0, 0, angle);
        
	}
	
	
	void Update () {
      
      

	}
}
