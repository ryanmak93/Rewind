using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject pauseMenu;

    private bool paused = false;

    void Start() {
        pauseMenu.SetActive(false);
    }

    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            paused = !paused;
            pauseMenu.SetActive(paused);
            Time.timeScale = paused ? 0 : 1;
            Debug.Log(Time.timeScale);
        }
    }

    public void Resume() {
        Debug.Log("clicked resume button");
        paused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart() {
        Debug.Log("clicked restart button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenu() {
        Debug.Log("clicked main menu button");
        SceneManager.LoadScene(0);
    }

    public void Quit() {
        Debug.Log("clicked quit button");
        Application.Quit();
    }
}
