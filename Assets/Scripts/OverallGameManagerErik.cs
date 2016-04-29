using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OverallGameManagerErik : MonoBehaviour {

    public static int RobotNumber;
    static int NumberCorrect = 0;
    static int NumberIncorrect = 0;
    public int numberToWin, numberToLose;
    public static bool levelFinished;
    public static bool isGameActive = false;

    int randomizer=8, previousPuzzle = 7;
    
    public GameObject[] puzzles = new GameObject[3];

    private int puzzleToLoad;

    // Use this for initialization

    void Start()
    {
        randomizer = Random.Range(0, 3);
        RobotNumber = Random.Range(1, 4);
        puzzleToLoad = Random.Range(1, 4);

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

    }

    // Update is called once per frame
    void Update()
    {
        if (NumberCorrect == numberToWin)
        {
            Debug.Log("YOU ARE AMAZING");
            //SceneManager.LoadScene(0);
        }
        else if (NumberIncorrect == numberToLose)
        {
            Debug.Log("YOU SUCK AT THIS GAME");
            //SceneManager.LoadScene(0);
        }
        if (isGameActive)
        {
            //dont do anything basically
        }

        else
        {

            //spawn a new puzzle
            while (randomizer == previousPuzzle)
            {
                randomizer = Random.Range(0, 3);
            }
            previousPuzzle = randomizer;
			GameObject myPuzzle = (GameObject)Instantiate(puzzles[0], transform.position, puzzles[0].transform.rotation);


        }

    }

    public static void PuzzleWon(GameObject myGO)
    {
        NumberCorrect++;
        isGameActive = false;
        Destroy(myGO);
    }

    public static void MadeError()
    {
        NumberIncorrect++;
        Debug.Log("Strike" + NumberIncorrect);
    }
}
