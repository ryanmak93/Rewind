using UnityEngine;
using System.Collections;

public class cabinetScript : MonoBehaviour {

	public GameObject Ham;
	public GameObject cabinetOpen;
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

	void OnMouseUp()
	{
		Destroy (transform.gameObject);
		Instantiate (Ham);
		Instantiate (cabinetOpen);
	}
}
