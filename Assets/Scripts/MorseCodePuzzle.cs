using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MorseCodePuzzle : MonoBehaviour
{

	public AudioSource soundManager;
	public AudioClip[] sounds;
	int pinkClickCounter, blackClickCounter, randomSoundChooser;
	int pinkMouseClicksNeeded = 30;
	int blackMouseClicksNeeded = 5;
	int dialNumber = 5;
	public float totalTime = 10.0f;
	float clickDelay;
	public Text timerText;
	bool wasBlackClicked;
	public Transform arrowSprite;

	void Start ()
	{
		randomSoundChooser = Random.Range (2, 4);
		//Play random sound at start of puzzle.
		soundManager.PlayOneShot (sounds [randomSoundChooser], 1f);
		Debug.Log (randomSoundChooser);
	}

	// Update is called once per frame
	void Update ()
	{
		ReplaySound ();
		ResetButton ();
		string timerTextInSeconds = string.Format ("{1:00}", Mathf.Floor (totalTime / 60), totalTime % 60); //Displays timer in seconds.
		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit mouseRayInfo = new RaycastHit ();

		//Detect which button is being pressed and raise its counter.
		if (Input.GetMouseButtonDown (0) && Physics.Raycast (mouseRay, out mouseRayInfo, 1000f)) {
			if (mouseRayInfo.collider.tag == "pink") {
				pinkClickCounter++;
			} 

			if (mouseRayInfo.collider.tag == "black") {
				//If you haven't already clicked in the past 1 second, you can click & raise counter (see ResetButton function).
				if (!wasBlackClicked) {
					clickDelay = 1f;
					wasBlackClicked = true;
					blackClickCounter++;
					Debug.Log (blackClickCounter);
				}
			}
		}
			

		//"FASTER"/PINK BUTTON LOGIC.
		if (randomSoundChooser == 0) {
			//pressing black button is wrong.
			if (blackClickCounter > 0) {
				YouLose ();
			}
			//pressing pink button is correct...
			if (pinkClickCounter > 0) {
				//start counting down timer when you press pink button.
				Debug.Log (pinkClickCounter);
				totalTime -= Time.deltaTime;
				timerText.text = timerTextInSeconds.ToString ();
				//if you don't press x times in x seconds, lose
				if (totalTime <= 0 && pinkClickCounter < pinkMouseClicksNeeded) {
					YouLose ();
				}
				//if you do press x times in x seconds, win
				if (pinkClickCounter >= pinkMouseClicksNeeded) {
					YouWon ();
				}
			}
		}
						
		//"SLOWER"/BLACK BUTTON LOGIC.
		if (randomSoundChooser == 1) {
			//pressing pink button is wrong.
			if (pinkClickCounter > 0) {
				YouLose ();
			}
			//pressing black button is correct...	
			if (blackClickCounter > 0) {
				totalTime -= Time.deltaTime;
				timerText.text = timerTextInSeconds.ToString ();
				//if you don't press x times in x seconds, lose
				if (totalTime <= 0 && blackClickCounter < blackMouseClicksNeeded) {
					YouLose ();
				}
				//if you do press x times in x seconds, win
				if (blackClickCounter >= blackMouseClicksNeeded) {
					YouWon ();
				}
			}
		}


		//"HARDER"/DIAL UP LOGIC.
		if (randomSoundChooser == 2) {
			//You should not be pressing either button.
			if (blackClickCounter > 0) {
				YouLose ();
			}
			if (pinkClickCounter > 0) {
				YouLose ();
			}
		}

		//"GENTLE"/DIAL DOWN LOGIC.
		//You should not be pressing either button.
		if (blackClickCounter > 0) {
			YouLose ();
		}
		if (pinkClickCounter > 0) {
			YouLose ();
		}
	}

	//LOGIC FOR WINNING WITH DIAL PAD.
	public void DialPad(){
		if (randomSoundChooser == 2) {
			//Need to turn dial UP to win.
			if (dialNumber == 9) {
				YouWon ();
			} else if (dialNumber != 9) {
				YouLose ();
			}
		}

		if (randomSoundChooser == 3){
			//Need to turn dial DOWN to win.
			if (dialNumber == 2) {
				YouWon ();
			} else if (dialNumber != 2) {
				YouLose ();
			}
		}
	}


	public void ResetButton ()
	{
		//If you pressed the black button, start counting down the delay until you can press it again.
		if (wasBlackClicked && clickDelay > 0) {
			clickDelay -= Time.deltaTime;
			//If you press during this countdown, you lose.
			if (Input.GetMouseButtonDown (0)) {
				YouLose ();
			}
		}

		//Once countdown is done, reset values to allow for clicking again.
		if (clickDelay < 0) {
			clickDelay = 0;
			wasBlackClicked = false;
		}
	}

	public void ReplaySound ()
	{
		//Replay sound on right click.
		if (Input.GetMouseButtonDown (1)) {
			soundManager.PlayOneShot (sounds [randomSoundChooser], 1f);
		}
	}

	public void RotateArrow ()
	{
		Debug.Log ("clicked dial");
		Debug.Log (dialNumber);

		arrowSprite.Rotate (0f, 0f, -40f);
		if (dialNumber <= 8) {
			dialNumber++;
		} else if (dialNumber >= 9) {
			dialNumber = 0;
		}
	}

	public void YouLose ()
	{
		Debug.Log ("you lost");
	}

	public void YouWon ()
	{
		Debug.Log ("you won");
	}
}
