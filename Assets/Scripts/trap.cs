using UnityEngine;
using System.Collections;

public class trap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		
		var name = other.gameObject.name;
		print (name);
		if (name == "Player") {
			print ("Trap");
			Destroy (transform.gameObject);
			var frame = GameObject.Find ("BottomFrame");
			print (frame.transform.position);
			Destroy (frame);
		}
	}
}
