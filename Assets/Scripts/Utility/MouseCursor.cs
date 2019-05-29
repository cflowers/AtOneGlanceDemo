using UnityEngine;
using System.Collections;

public class MouseCursor : MonoBehaviour {
    
    public Texture2D cursorTexture;
    public Texture2D handTexture;
    public Texture2D eyeTexture;
    public Texture2D backTexture;

    [HideInInspector]
    public Texture2D origTexture;
    
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

	
	void Awake () {
	  Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
      origTexture = cursorTexture;
    }

    public void setCursor()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

}
