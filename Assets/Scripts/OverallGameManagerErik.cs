using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OverallGameManagerErik : MonoBehaviour {

	public static int RobotNumber;
    public static int NumberCorrect;
    public static int NumberIncorrect;
    public static bool levelFinished;

    private int puzzleToLoad;

	// Use this for initialization

	void Start () {

        RobotNumber = Random.Range(1, 4);
        puzzleToLoad = Random.Range(1, 4);

    }
	
	// Update is called once per frame
	void Update () {
        if (RobotNumber == 1)
        {
            //instantiate Robot 1
        }
        if (RobotNumber == 2)
        {
            //instantiate Robot 2
        }
        if (RobotNumber == 3)
        {
            //instantiate Robot 3
        }

        // If the current scene isn't an acrtive puzzle select a random level to load
        //if (SceneManager.GetActiveScene == SceneManager.GetSceneByName "Not A Puzzle Scene")
        //{
        //if (puzzleToLoad == 1)
        //{
        //   SceneManager.LoadScene("WhateverPuzzleAssignedTo1");
        //}
        //if (puzzleToLoad == 2)
        //{
        //    SceneManager.LoadScene("WhateverPuzzleAssignedTo2");
        //}
        //if (puzzleToLoad == 3)
        //{
        //   SceneManager.LoadScene("WhateverPuzzleAssignedTo3");
        //}
        //}
        // If a level has been finished load one of the other two levels


    }
}
