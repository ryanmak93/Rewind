// Author: Shi Yin
// Date: 2/7/2016
// This script is responsible for loading levels and quiting the game

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    // load the scene with name name
    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("currentlevel", SceneManager.GetActiveScene().buildIndex);
    }

    // load the next scene in the building setting
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // quit the game
    public void QuitGame(string name)
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void Start()
    {
        if(SceneManager.GetActiveScene().name == "Lose")
        {
            PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount") + 1);
        }
    }
}
