using UnityEngine;
using System.Collections;

public class hamScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "Floor") {
			print ("ham hit the floor");
			Destroy (transform.gameObject.GetComponent<Rigidbody2D> ());
			Destroy (transform.gameObject.GetComponent<PolygonCollider2D> ());

		}
	}
}
