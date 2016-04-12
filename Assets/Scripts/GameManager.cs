//
//
// This script is the main controller of the game, responsible for the game logic

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private GameObject flower;
    private GameObject exitDoor;
    private GameObject window;

    public float flowerSpeed;
    public float beeSpeed;

    private bool isWindowClosed = false;
    private bool isFlowerInRoom = false;

    private GameObject player;

    private LevelManager levelManager;

    void Start() {
        flower = GameObject.Find("Flower");
        exitDoor = GameObject.Find("Exit Door");
        window = GameObject.Find("Window");
        player = GameObject.FindWithTag("Player");
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void RunLv1() {
        // if window is not closed, player is killed by vase
        if (!isWindowClosed) {
            // TODO player moves towards exit door
            // TODO flower starts to drop half way
            // TODO if player arrived beneath flower, then stop
            // collision, death, reset - implemented in PlayerManager
        }
        // if window is closed but flower is not in the room, player is killed by bee
        else if (!isFlowerInRoom) {
            // TODO player moves towards exit door
            // TODO bee fly towards player half way
            // collision, death, reset - implemented in PlayerManager
        }
        // if window is closed and flower is in the room, player passes the level
        else {
            // TODO player moves towards exit door
            // pass the level, load next level - implemented in PlayerManager
        }
    }

    public void RunLv2() {

    }

    public void RunLv3() {

    }

}
