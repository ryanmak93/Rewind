using UnityEngine;
using System.Collections;

public class leverScript : MonoBehaviour {
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
		
		var isOn = GameObject.Find ("jigsaw").GetComponent<JigsawScript> ().isOn;
		if (isOn) {
			print ("jigsaw is on");
		    GameObject.Find ("jigsaw").GetComponent<JigsawScript> ().isOn = false;
			var animator = GameObject.Find ("jigsaw").GetComponent<Animator> ();
			var collider = GameObject.Find ("jigsaw").GetComponent<CircleCollider2D> ();
			Destroy (animator);
			Destroy (collider);
		}
		var ham = GameObject.Find ("ham(Clone)");
		//print (ham.name);
		if (ham != null) {
			GameObject.Find ("wolf").GetComponent<WolfScript> ().attack = "ham";
			GameObject.Find ("wolf").GetComponent<BoxCollider2D> ().isTrigger = true;
			Destroy (GameObject.Find ("wolf").GetComponent<Animator> ());
		} else {
			GameObject.Find ("wolf").GetComponent<WolfScript> ().attack = "player";
			Destroy (GameObject.Find ("wolf").GetComponent<Animator> ());
		}

	}
}
