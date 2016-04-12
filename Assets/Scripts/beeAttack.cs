using UnityEngine;
using System.Collections;

public class beeAttack : MonoBehaviour {

	public bool moveBee = false;
	public float speed = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (moveBee) {
			
			GameObject player = GameObject.Find ("Player");
			GameObject flower = GameObject.Find ("Flower");

			var start = transform.position;
			Vector3 dest;

			if (flower != null) {
				print ("in bee:" + flower.name);
				dest = flower.transform.position;
			} else {
				print ("MOVING TO PLAYER");
				dest = player.transform.position;
			}

			//print (player.transform.position);
			float step = speed * Time.deltaTime;
			step *= 20.0f;
			transform.position = Vector3.MoveTowards(start,dest, 0.3f);

		}

	}
	/*void OnCollisionEnter2D(Collision2D other) {
		var colName = other.gameObject.name;
		print ("in bee:" + name);
		if (name == "GiantBee") {
			Application.LoadLevel ("Lose");
		}
	}
	*/

}
