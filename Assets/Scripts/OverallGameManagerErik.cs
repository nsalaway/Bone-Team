using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OverallGameManagerErik : MonoBehaviour {

    public static int RobotNumber;
    public static int antenna;
    public static int eyes;
    public static int NumberCorrect = 0;
    public static int NumberIncorrect = 0;
    public int numberToWin, numberToLose;
    //public static bool levelFinished;
    public static bool isGameActive = false;

    int randomizer=8, previousPuzzle = 7;
    
    public GameObject[] puzzles = new GameObject[3];

    private int puzzleToLoad;
    private static int wonSound;
    private static int lossSound;

    public static AudioSource Pleasure1;
    public static AudioSource Pleasure2;
    public static AudioSource Pleasure3;
    public static AudioSource Fail1;
    public static AudioSource Fail2;
    public static AudioSource Fail3;

    // Use this for initialization

    void Start()
    {
        RandomizeRobot();
        NumberCorrect = 0;
        NumberIncorrect = 0;
        isGameActive = false;
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
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
            GameObject myPuzzle = (GameObject)Instantiate(puzzles[randomizer], transform.position, puzzles[randomizer].transform.rotation);


        }

    }

    public static void PuzzleWon(GameObject myGO)
    {
        NumberCorrect++;
        isGameActive = false;
        Destroy(myGO);
        wonSound = Random.Range(0, 3);
        if (wonSound == 0)
        {
            Pleasure1.Play();
        }
        if (wonSound == 1)
        {
            Pleasure2.Play();
        }
        if (wonSound == 2)
        {
            Pleasure3.Play();
        }
    }

    public static void MadeError()
    {
        NumberIncorrect++;
        Debug.Log("Strike" + NumberIncorrect);
        lossSound = Random.Range(0, 3);

        if (lossSound == 0)
        {
            Fail1.Play();
        }
        if (lossSound == 1)
        {
            Fail2.Play();
        }
        if (lossSound == 2)
        {
            Fail3.Play();
        }
    }

    void RestartGame()
    {

        SceneManager.LoadScene(0);

    }

    void RandomizeRobot()
    {
        int randomizer = Random.Range(0, 3);
        antenna = randomizer;
        Debug.Log("Antenna: " + antenna);
        randomizer = Random.Range(0, 3);
        eyes = randomizer;
        Debug.Log("Eyes: " + eyes);
    }
}
