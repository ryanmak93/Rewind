using UnityEngine;
using System.Collections;

public class Exit_door : MonoBehaviour {
    public Texture2D cursorTexture;
    public Texture2D cursorTexturedefault;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Use this for initialization


    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(cursorTexturedefault, Vector2.zero, cursorMode);
    }
}
