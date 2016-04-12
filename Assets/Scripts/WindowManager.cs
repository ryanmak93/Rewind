using UnityEngine;
using System.Collections;

public class WindowManager : MonoBehaviour {

    public Sprite closedWindow;
    public Sprite closedRightWindow;
    public Sprite closedLeftWindow;
    public Sprite openWindow;
	public string Window_status;

	// Use this for initialization
	void Start () {
		Window_status = "all_open";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUp() {
        Debug.Log("Mouse clicked in Window");
        gameObject.GetComponent<SpriteRenderer>().sprite = closedWindow;
    }
}
