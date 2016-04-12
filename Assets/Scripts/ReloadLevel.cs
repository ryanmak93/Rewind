using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
        int level = PlayerPrefs.GetInt("currentlevel");
        Debug.Log("Reload level");
        Debug.Log(level);
        SceneManager.LoadScene(level);
    }
}
