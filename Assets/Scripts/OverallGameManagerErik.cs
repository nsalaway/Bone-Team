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
	public static int numberToWin;
	int numberToLose = 3;
    //public static bool levelFinished;
    public static bool isGameActive = false;
	bool hasLost = false;
	bool hasWon = false;
	public static bool isWinningActive = false;
	public float overallGameTime = 900.0f;
	public Text gameTimerText;

	float timeMouseClicked;
    int randomizer=8, previousPuzzle = 7;
    
    public GameObject[] puzzles = new GameObject[3];

    private int puzzleToLoad;

    public AudioSource soundManager;
	public AudioClip explodeSound;
	public AudioClip winSound;
    public AudioClip[] soundsCorrect;
    public AudioClip[] soundsIncorrect;
	public AudioClip[] impatientSounds;
    static int randomSoundChooser;
    public static OverallGameManagerErik instance;

	public Image blackScreen;
	public Image correct1, correct2, correct3, correct4, correct5, correct6, correct7, incorrect1, incorrect2, incorrect3;
	//public Sprite correct1Off, correct2Off, correct3Off, correct4Off, correct5Off, correct6Off, correct7Off, incorrect1Off, incorrect2Off, incorrect3Off;
	public Sprite correctOn, incorrectOn;

    GameObject myPuzzle;


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
		blackScreen.enabled = false;
		Debug.Log (numberToWin + "towin");

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

		//Set progress indicators depending on difficulty level.
		if (numberToWin == 3) {
			correct4.enabled = false;
			correct5.enabled = false;
			correct6.enabled = false;
			correct7.enabled = false;
		} else if (numberToWin == 5) {
			correct4.enabled = true;
			correct5.enabled = true;
			correct6.enabled = false;
			correct7.enabled = false;
		} else if (numberToWin == 7) {
			//all active
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
			randomSoundChooser = Random.Range (0, 3);
			instance.soundManager.PlayOneShot (instance.impatientSounds [randomSoundChooser], 1f);
			timeMouseClicked = Time.time;
			randomSoundChooser = Random.Range (0, 3);
		}
		//Restart.
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
		//You won.
        if (NumberCorrect == numberToWin)
        {
			hasWon = true;
        }
		//You lost.
		if (NumberIncorrect == numberToLose || overallGameTime <= 0f)
        {
			hasLost = true;
        }
        if (isGameActive)
        {
            //dont do anything basically
        }
        else
        {
			if (!isWinningActive) {
				//spawn a new puzzle
				while (randomizer == previousPuzzle) {
					randomizer = Random.Range (0, 3);
				}
				previousPuzzle = randomizer;
				myPuzzle = (GameObject)Instantiate (puzzles [randomizer], puzzles [randomizer].transform.position, puzzles [randomizer].transform.rotation);
			}
		}

		if (hasLost == true) {
			StartCoroutine (LoadLoseScreen ());	
		}

		if (hasWon == true) {
			StartCoroutine (LoadWinScreen ());
		}

		//Progress indicators.
		if (NumberCorrect >= 1) {
			correct1.sprite = correctOn;
		}
		if (NumberCorrect >= 2) {
			correct2.sprite = correctOn;
		}
		if (NumberCorrect >= 3) {
			correct3.sprite = correctOn;
		}
		if (correct4.enabled == true && NumberCorrect >= 4) {
			correct4.sprite = correctOn;
		}
		if (correct5.enabled == true && NumberCorrect >= 5) {
			correct5.sprite = correctOn;
		}
		if (correct6.enabled == true && NumberCorrect >= 6) {
			correct6.sprite = correctOn;
		}
		if (correct7.enabled == true && NumberCorrect >= 7) {
			correct7.sprite = correctOn;
		}
		if (NumberIncorrect >= 1) {
			incorrect1.sprite = incorrectOn;
		}
		if (NumberIncorrect >= 2) {
			incorrect2.sprite = incorrectOn;
		}

    }
	/// <summary>
	/// When you win a puzzle, destroy it & add score.
	/// </summary>
    public static void PuzzleWon(GameObject myGO)
    {
		if (isWinningActive == false) {
			NumberCorrect++;
			instance.StartCoroutine (instance.LoadNewPuzzle ());
			Destroy (myGO);
			Debug.Log ("correctly solved puzzle");
			randomSoundChooser = Random.Range (0, 3);
			instance.soundManager.PlayOneShot (instance.soundsCorrect [randomSoundChooser], 1f);
		}
    }

    //Function to call on puzzl skip

    public void PuzzleSkip()
    {
        MadeError();
        Destroy(myPuzzle);

		if (NumberIncorrect != numberToLose) {
			instance.StartCoroutine (instance.LoadNewPuzzle ());  
		}
    }

    /// <summary>
    /// When you make an error, add a strike.
    /// </summary>
    public static void MadeError()
    {
        NumberIncorrect++;
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

	public IEnumerator LoadNewPuzzle(){
		yield return new WaitForSeconds (1f);
		isGameActive = false;
	}

	public IEnumerator LoadLoseScreen(){
		incorrect3.sprite = incorrectOn;
		hasLost = false;
		NumberIncorrect = 0;
		NumberCorrect = 0;
		overallGameTime = 900.0f;
		gameTimerText.enabled = false;
		yield return new WaitForSeconds (0.5f);
		soundManager.PlayOneShot (explodeSound, 1f);
		yield return new WaitForSeconds (5f);
		blackScreen.enabled = true;
		yield return new WaitForSeconds (5f);
		SceneManager.LoadScene (5);
	}

	public IEnumerator LoadWinScreen(){
		isWinningActive = true;
		hasWon = false;
		NumberCorrect = 0;
		NumberIncorrect = 0;
		overallGameTime = 900.0f;
		gameTimerText.enabled = false;
		yield return new WaitForSeconds (0.7f);
		soundManager.PlayOneShot (winSound, 1f);
		yield return new WaitForSeconds (4f);
		blackScreen.enabled = true;
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene (4);
	}
}
