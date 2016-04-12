using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Deathtext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Text deathtext = this.gameObject.GetComponent<Text>();
        deathtext.text = PlayerPrefs.GetInt("DeathCount").ToString();
	}
}
