using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other) {
		var colName = other.gameObject.name;

		if (GameObject.Find ("trap") != null) {
			//print ("TRIGGERING TRAP");

		} else if (colName == "Flower") {
			print ("in Player NAME: " + other.gameObject.name);
            //Debug.Log(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("currentlevel", SceneManager.GetActiveScene().buildIndex);
            //PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount") + 1);
            SceneManager.LoadScene("Lose");
            
        }

		if (colName == "Giant Bee") {
			print ("in Player" + colName);
            //Debug.Log(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("currentlevel", SceneManager.GetActiveScene().buildIndex);
            //PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount") + 1);
            SceneManager.LoadScene("Lose");
        }

			
	}

}
