using UnityEngine;
using System.Collections;

public class WindowObjectManager : MonoBehaviour {

	public Object closedWindow;
	public Object closedRightWindow;
	public Object closedLeftWindow;
	public Object openWindow;
	public string Window_status;
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
    // Use this for initialization
    void Start () {
		Window_status = "all_open";

	}

	// Update is called once per frame
	void Update () {
		//print ("hello");
	}

	void OnMouseUp() {
		Debug.Log("Mouse clicked in Window");
        //if (window.name == "LeftWing") {
        //	print ("left wing touched");
        //}
        //gameObject.GetComponent<SpriteRenderer>(). = closedWindow;
    }
}
