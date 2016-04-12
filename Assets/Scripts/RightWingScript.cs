using UnityEngine;
using System.Collections;

public class RightWingScript : MonoBehaviour {
	
	public Object openW;
	public Object openWRight;
	public Object openWLeft;
	public Object closedW;
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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		print ("THIS IS RIGHT");
		var parent = transform.parent.gameObject;
		//print ("parent: " + parent.name);
		if (parent.name == "OpenWindow") {
			//print ("window is open");
			Instantiate (openWRight);
			Destroy (parent);
		}
		if (parent.name == "OpenWindow(Clone)") {
			//print ("window is open");
			Instantiate (openWRight);

			Destroy (parent);
		}
		if (parent.name == "OpenWindowRight(Clone)") {
			//print ("window is open");
			Instantiate (openW);
			Destroy (parent);
		}
		if (parent.name == "OpenWindowLeft(Clone)") {
			//print ("window is open");
			Instantiate (closedW);
			Destroy (parent);
		}
		if (parent.name == "ClosedWindow(Clone)") {
			print ("window is Closed");
			Instantiate (openWLeft);
			Destroy (parent);
		}


	}
}
