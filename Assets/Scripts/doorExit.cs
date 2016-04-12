using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class doorExit : MonoBehaviour {
	//public Transform target;
	public float speed = 20.0f;
	public bool movePlayer = false;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (movePlayer) {
			GameObject player = GameObject.Find ("Player");

			var dest = transform.position;
			dest.y = 2.59f;
			//print (player.transform.position);
			float step = speed * Time.deltaTime;
			step *= 2.0f;
			player.transform.position = Vector3.MoveTowards(player.transform.position, dest, step);
			
		}

	
	}

	void OnMouseUp(){
		print ("door click");
		movePlayer = true;

	}
	void OnCollisionEnter2D(Collision2D other){
		var name = other.gameObject.name;
		if (name == "Player") {
			LoadNextLevel ();
		}
	}
	public void LoadNextLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
