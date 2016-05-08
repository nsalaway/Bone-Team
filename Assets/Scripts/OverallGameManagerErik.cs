using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverallGameManagerErik : MonoBehaviour {

    public static int RobotNumber;
    public static int antenna;
    public static int eyes;
    public static int NumberCorrect = 0;
    public static int NumberIncorrect = 0;
    public int numberToWin, numberToLose;
    //public static bool levelFinished;
    public static bool isGameActive = false;
	public float overallGameTime = 600.0f;
	public Text gameTimerText;
	public static Image progressBar;

	float timeMouseClicked;
    int randomizer=8, previousPuzzle = 7;
    
    public GameObject[] puzzles = new GameObject[3];

    private int puzzleToLoad;

    public AudioSource soundManager;
	public AudioClip hurryUp;
    public AudioClip[] soundsCorrect;
    public AudioClip[] soundsIncorrect;
    static int randomSoundChooser;
    public static OverallGameManagerErik instance;



    // Use this for initialization
    //progressBar.fillAmount = (float)"score"/float("math stuff");

    void Start()
    {
        instance = this;
        RandomizeRobot();
        NumberCorrect = 0;
        NumberIncorrect = 0;
        isGameActive = false;
        randomizer = Random.Range(0, 3);
        RobotNumber = Random.Range(1, 4);
        puzzleToLoad = Random.Range(1, 4);
		progressBar = GameObject.Find ("Fill").GetComponent<Image>();
		progressBar.fillAmount = (50f / 100f);

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
		//Timer.
		overallGameTime -= Time.deltaTime;
		string timerTextInSeconds = string.Format ("{0:0}:{1:00}", Mathf.Floor (overallGameTime / 60), overallGameTime % 60); //Displays timer in minutes & seconds.
		gameTimerText.text = timerTextInSeconds.ToString ();

		//When did the player last click?
		if (Input.GetMouseButtonDown (0)) {
			timeMouseClicked = Time.time;
		}
		//If the player clicked more than 30 seconds ago, play sound.
		if (randomizer != 1 && Time.time >= timeMouseClicked + 30f) {
			soundManager.PlayOneShot (hurryUp, 1f);
			timeMouseClicked = Time.time;
		}
		//Restart.
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
		//You won.
        if (NumberCorrect == numberToWin)
        {
			SceneManager.LoadScene (4);
        }
		//You lost.
		if (NumberIncorrect == numberToLose || overallGameTime <= 0f)
        {
			SceneManager.LoadScene (5);
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
			GameObject myPuzzle = (GameObject)Instantiate(puzzles[randomizer], puzzles[randomizer].transform.position, puzzles[randomizer].transform.rotation);
		}

    }
	/// <summary>
	/// When you win a puzzle, destroy it & add score.
	/// </summary>
    public static void PuzzleWon(GameObject myGO)
    {
        NumberCorrect++;
		progressBar.fillAmount = ((float)NumberCorrect * 10)/(float)100;
        isGameActive = false;
        Destroy(myGO);
		Debug.Log ("correctly solved puzzle");
        randomSoundChooser = Random.Range(0, 3);
        instance.soundManager.PlayOneShot(instance.soundsCorrect[randomSoundChooser], 1f);
    }

	/// <summary>
	/// When you make an error, add a strike.
	/// </summary>
    public static void MadeError()
    {
        NumberIncorrect++;
		progressBar.fillAmount = 1f - (((float)NumberIncorrect * 10)/(float)100);
        Debug.Log("Strike" + NumberIncorrect);
        randomSoundChooser = Random.Range(0, 3);
        instance.soundManager.PlayOneShot(instance.soundsIncorrect[randomSoundChooser], 1f);

    }
		
    void RestartGame()
    {

        SceneManager.LoadScene(3);

    }

	/// <summary>
	/// Randomizes the robot.
	/// </summary>
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
