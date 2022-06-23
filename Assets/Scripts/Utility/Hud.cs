using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//move stupid picture
public class Hud : MonoBehaviour {

  
    public RawImage pic;
    public Transform book;
    public bool buttonPressed = false;
    public Canvas canvas;
	
	void Start () {
      
        reset();
	}

   

    void Update()
    {
        if (buttonPressed)
        {
            float step = 300 * Time.deltaTime;
            pic.enabled = true;
            pic.transform.position = Vector3.MoveTowards(pic.transform.position, book.position, step);
           
             
            if (pic.transform.position.x >= book.position.x) 
            {
                canvas.sortingOrder = -1;
                buttonPressed = false;
                reset();
                pic.enabled = false;
            }

        }
     }

    void reset()
    {
        pic.GetComponent<RectTransform>().anchoredPosition = new Vector2(-40f, 80f);
        pic.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0f);
        pic.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0f);
        pic.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
    }
    

    
}
