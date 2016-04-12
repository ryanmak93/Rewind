// Author: Shi Yin
// Date: 2/7/2016
// This script is responsible for keeping the music player Singleton throughout all scenes

using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    public static MusicPlayer instance = null;

    void Awake() {
        Debug.Log("Awake " + GetInstanceID());

        // if an instance exists, distroy the newly constructed game object
        // otherwise make this game object the singleton instance and don't destroy it on loading next scene
        if (instance != null) {
            Destroy(gameObject);
        }
        else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
