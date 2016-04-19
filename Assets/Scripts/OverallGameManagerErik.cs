using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OverallGameManagerErik : MonoBehaviour {

    static int RobotNumber;
    static int NumberCorrect;
    static int NumberIncorrect;

	// Use this for initialization

	void Start () {

        RobotNumber = Random.Range(1, 4);

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

        //if (SceneManager.GetActiveScene == SceneManager.GetSceneByName)

    }
}
