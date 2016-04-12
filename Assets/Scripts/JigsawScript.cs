using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class JigsawScript : MonoBehaviour {

	public bool isOn = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D other){
		print ("got the player");
		var name = other.gameObject.name;
		if(name == "Player" && isOn == true){
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("currentlevel", SceneManager.GetActiveScene().buildIndex);
            //PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount") + 1);
            SceneManager.LoadScene("Lose");
        }
	}
}
