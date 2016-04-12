using UnityEngine;
using System.Collections;

public class beeTrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D other){
		Destroy (transform.gameObject);
		this.transform.parent.GetComponent<beeAttack> ().moveBee = true;
		this.transform.parent.GetComponent<Animator> ().applyRootMotion = true;

	}
}
