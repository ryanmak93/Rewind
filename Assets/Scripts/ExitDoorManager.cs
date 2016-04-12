using UnityEngine;
using System.Collections;

public class ExitDoorManager : MonoBehaviour {

    public GameManager game;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUp() {
        Debug.Log("Mouse clicked in Exit Door");
        game.RunLv1();
    }
}
