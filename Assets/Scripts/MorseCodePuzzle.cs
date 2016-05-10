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
	bool wasBlackClicked;
	public Transform arrowParentCube;
	bool wasDialPressed;
	public Transform arrowSprite;
	public Sprite pinkPressed, bluePressed, pinkUp, blueUp;
	Image originalPinkSprite, originalBlueSprite;

	void Start ()
	{
        OverallGameManagerErik.isGameActive = true;
        randomSoundChooser = Random.Range (0, 4);
		//Play random sound at start of puzzle.
		soundManager.PlayOneShot (sounds [randomSoundChooser], 1f);
		Debug.Log ("sound #" + randomSoundChooser);
		originalPinkSprite = GameObject.Find ("pinkButton").GetComponent<Image> ();
		originalBlueSprite = GameObject.Find ("blueButton").GetComponent<Image> ();

	}

	// Update is called once per frame
	void Update ()
	{
		ReplaySound ();
		ResetButton ();
		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit mouseRayInfo = new RaycastHit ();

		//Replay sound on right click.
		if (Input.GetMouseButtonDown (1)) {
			soundManager.Stop ();
			StartCoroutine (ReplaySound());

		}

		//Detect which button is being pressed and raise its counter.
		if (Input.GetMouseButtonDown (0) && Physics.Raycast (mouseRay, out mouseRayInfo, 1000f)) {
			if (mouseRayInfo.collider.tag == "pink") {
				pinkClickCounter++;
				StartCoroutine (ChangePinkButton ());
				Debug.Log ("pink counter = " + pinkClickCounter);
			} 

			if (mouseRayInfo.collider.tag == "black") {
				StartCoroutine (ChangeBlueButton ());
				//If you haven't already clicked in the past 2 seconds, you can click & raise counter (see ResetButton function).
				if (!wasBlackClicked) {
					clickDelay = 1f;
					wasBlackClicked = true;
					blackClickCounter++;
					Debug.Log ("black counter = " + blackClickCounter);
				}
			}
		}
			
		//==============================================================================================================================================================
		//"FASTER"/PINK BUTTON LOGIC.
		if (randomSoundChooser == 0) {
			//pressing black button is wrong.
			if (blackClickCounter > 0) {
				YouLose ();
			}
			//pressing dial is wrong.
			if (wasDialPressed == true) {
				Debug.Log ("dial pressed - you lose");
				YouLose ();
			}
			//pressing pink button is correct...
			if (pinkClickCounter > 0) {
				//start counting down timer when you press pink button.
				totalTime -= Time.deltaTime;
				//if you don't press x times in x seconds, lose
				if (totalTime <= 0 && pinkClickCounter < pinkMouseClicksNeeded) {
					Debug.Log ("time is up");
					YouLose ();
				}
				//if you do press x times in x seconds, win
				if (pinkClickCounter >= pinkMouseClicksNeeded) {
					YouWon ();
				}
			}
		}
			
		//==============================================================================================================================================================
		//"SLOWER"/BLACK BUTTON LOGIC.
		if (randomSoundChooser == 1) {
			//pressing pink button is wrong.
			if (pinkClickCounter > 0) {
				YouLose ();
			}
			//pressing dial is wrong.
			if (wasDialPressed == true) {
				Debug.Log ("dial pressed - you lose");
				YouLose ();
			}
			//pressing black button is correct...	
			if (blackClickCounter > 0) {
            }
            //pressing black button is correct...	
            if (blackClickCounter > 0) {
				totalTime -= Time.deltaTime;
				//if you don't press x times in x seconds, lose
				if (totalTime <= 0 && blackClickCounter < blackMouseClicksNeeded) {
					Debug.Log ("time is up");
					YouLose ();
				}
				//if you do press x times in x seconds, win
				if (blackClickCounter >= blackMouseClicksNeeded) {
					YouWon ();
				}
			}
		}

		//==============================================================================================================================================================
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

		//==============================================================================================================================================================
		//"GENTLE"/DIAL DOWN LOGIC.
		//You should not be pressing either button.
		if (randomSoundChooser == 3) {
			if (blackClickCounter > 0) {
				YouLose ();
			}
			if (pinkClickCounter > 0) {
				YouLose ();
			}
		}
	}

	//==============================================================================================================================================================
	//LOGIC FOR WINNING WITH DIAL PAD.

	public void DialPad ()
	{
		if (randomSoundChooser == 2) {
			//Need to turn dial UP to win.
			if (dialNumber == 9) {
				YouWon ();
			} else if (dialNumber != 9) {
				YouLose ();
			}
		}

		if (randomSoundChooser == 3) {
			//Need to turn dial DOWN to win.
			if (dialNumber == 2) {
				YouWon ();
			} else if (dialNumber != 2) {
				YouLose ();
			}
		}
	}

	//WHEN YOU PRESS THE DIAL PAD...
	public void RotateArrow ()
	{
		wasDialPressed = true;

		//rotate arrow & increment dailNumber
		arrowParentCube.Rotate (0f, 50f, 0f);
		if (dialNumber <= 8) {
			dialNumber++;
		} else if (dialNumber >= 9) {
			dialNumber = 0;
		}
		Debug.Log ("clicked dial " + dialNumber);
	}

	//==============================================================================================================================================================
	/// <summary>
	/// Resets the black button delay (so you can press again after 1 second).
	/// </summary>
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

	/// <summary>
	/// Pauses & then replays the chosen robot sound.
	/// </summary>
	public IEnumerator ReplaySound ()
	{
		yield return new WaitForSeconds (1.0f);
		soundManager.PlayOneShot (sounds [randomSoundChooser], 1f);
	}

	public void YouLose ()
	{
        OverallGameManagerErik.MadeError();
		pinkClickCounter = 0;
		blackClickCounter = 0;
		dialNumber = 5;
		totalTime = 10.0f;
		wasDialPressed = false;
		wasBlackClicked = false;
    }

	public void YouWon ()
	{
        OverallGameManagerErik.PuzzleWon(transform.parent.gameObject);
    }

	/// <summary>
	/// Changes the pink button sprite to "pushed".
	/// </summary>
	public IEnumerator ChangePinkButton(){
		originalPinkSprite.sprite = pinkPressed;
		yield return new WaitForSeconds (0.1f);
		originalPinkSprite.sprite = pinkUp;
	}

	/// <summary>
	/// Changes the blue button sprite to "pushed".
	/// </summary>
	public IEnumerator ChangeBlueButton(){
		originalBlueSprite.sprite = bluePressed;
		yield return new WaitForSeconds (0.1f);
		originalBlueSprite.sprite = blueUp;
	}
}
