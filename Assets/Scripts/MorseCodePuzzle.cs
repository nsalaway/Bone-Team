using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MorseCodePuzzle : MonoBehaviour
{

	public AudioSource soundManager;
	public AudioClip[] sounds;
	int pinkClickCounter, blackClickCounter, randomSoundChooser;
	public int pinkMouseClicksNeeded = 30;
	public int blackMouseClicksNeeded = 5;
	public float totalTime = 10.0f;
	float clickDelay;
	public Text timerText;
	bool wasBlackClicked;

	void Start ()
	{
		randomSoundChooser = Random.Range (0, 2);

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
				Debug.Log ("boo you lose - wrong button");
			}
			//pressing pink button is correct...
			if (pinkClickCounter > 0) {
				//start counting down timer when you press pink button.
				Debug.Log (pinkClickCounter);
				totalTime -= Time.deltaTime;
				timerText.text = timerTextInSeconds.ToString ();
				//if you don't press x times in x seconds, lose
				if (totalTime <= 0 && pinkClickCounter < pinkMouseClicksNeeded) {
					Debug.Log ("you lost - out of time");
				}
				//if you do press x times in x seconds, win
				if (pinkClickCounter >= pinkMouseClicksNeeded) {
					Debug.Log ("you won");
				}
			}
		}
						
		//"SLOWER"/BLACK BUTTON LOGIC.
		if (randomSoundChooser == 1) {
			//pressing pink button is wrong.
			if (pinkClickCounter > 0) {
				Debug.Log ("boo you lost - wrong button");
			}
			//pressing black button is correct...	
			if (blackClickCounter > 0) {
				totalTime -= Time.deltaTime;
				timerText.text = timerTextInSeconds.ToString ();
				//if you don't press x times in x seconds, lose
				if (totalTime <= 0 && blackClickCounter < blackMouseClicksNeeded) {
					Debug.Log ("you lost - out of time");
				}
				//if you do press x times in x seconds, win
				if (blackClickCounter >= blackMouseClicksNeeded) {
					Debug.Log ("you won");
				}
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
				Debug.Log ("you lose - too soon");
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
}
