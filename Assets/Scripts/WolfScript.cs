using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WolfScript : MonoBehaviour {

	public float speed = 3.0f;

	public string attack = "none";
	public bool eatingHam = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		var start = transform.position;
		Vector3 dest = start;
		GameObject player = GameObject.Find ("Player");
		GameObject ham = GameObject.Find ("ham(Clone)");

		if (attack == "player") {
			//print ("attacking player");
			dest = player.transform.position;

		}
		if(attack == "ham" && ham != null){
			//print ("getting ham");
			dest = ham.transform.position;
			eatingHam = true;
		}


		//print (player.transform.position);
		float step = speed * Time.deltaTime;
		step *= 20.0f;
		transform.position = Vector3.MoveTowards(start,dest, 0.3f);
	
	}

	void OnCollisionEnter2D(Collision2D other){
		print ("got the player");
		var name = other.gameObject.name;
		if(name == "Player" && eatingHam != true){
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("currentlevel", SceneManager.GetActiveScene().buildIndex);
            //PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount") + 1);
            SceneManager.LoadScene("Lose");

        }
	}
}
