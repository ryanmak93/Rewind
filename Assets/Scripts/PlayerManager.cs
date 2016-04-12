using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    LevelManager levelManager;

    void Start() {
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject == GameObject.Find("Exit Door")) {
            levelManager.LoadNextLevel();
        }
        else if (other.gameObject == GameObject.Find("Flower") || other.gameObject == GameObject.Find("Giant Bee")) {
            // TODO reset current scene
        }
        else {
            Debug.Log("Wrong Collider hit the player!");
        }
    }
}
