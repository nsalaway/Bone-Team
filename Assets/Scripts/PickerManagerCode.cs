using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickerManagerCode : MonoBehaviour
{
	public AudioSource soundManager;
	public AudioClip clickSound;

	public GameObject blueBox;
	public GameObject tealBox;
	public GameObject greenBox;
	public GameObject greyBox;
	public GameObject redBox;
	public GameObject pinkBox;
	public GameObject orangeBox;
	public GameObject yellowBox;
	public GameObject enterBox;
    
	private bool isClickedBlue = false;
	private bool isClickedTeal = false;
	private bool isClickedGreen = false;
	private bool isClickedGrey = false;
	private bool isClickedRed = false;
	private bool isClickedPink = false;
	private bool isClickedOrange = false;
	private bool isClickedYellow = false;

	private bool finalizeAnswere = false;

	private int State;
	private int Model;

	bool isLoaded = false;

	SpriteRenderer originalBlue, originalGreen, originalPurple, originalLightBlue, originalPink, originalRed, originalOrange, originalYellow;
	public Sprite blueUp, greenUp, purpleUp, lightBlueUp, pinkUp, redUp, orangeUp, yellowUp;
	public Sprite bluePressed, greenPressed, purplePressed, lightBluePressed, pinkPressed, redPressed, orangePressed, yellowPressed;

	// Use this for initialization
	void Start ()
	{
		OverallGameManagerErik.isGameActive = true;
		//DECLARE THE PUZZLE STATE AND ROBOT NUMBER
		State = Random.Range (1, 7);
   

		//===========================================================================================================================
		//iNSTANTIATE THE REQUIRED GAME OBJECTS FOR EACH STATE
		if (State == 1) {
			//(instantiate code for State here)
			spawnBlue ();
			spawnTeal ();
			spawnGreen ();
			spawnGrey ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

		}
		if (State == 2) {
			//(instantiate code for State here)
			spawnBlue ();
			spawnTeal ();
			spawnGrey ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

		}
		if (State == 3) {
			//(instantiate code for State here)
			spawnBlue ();
			spawnTeal ();
			spawnGreen ();
			spawnGrey ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

		}
		if (State == 4) {
			//(instantiate code for State here)
			spawnBlue ();
			spawnGreen ();
			spawnGrey ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();

		}
		if (State == 5) {
			//(instantiate code for State here)
			spawnBlue ();
			spawnTeal ();
			spawnGreen ();
			spawnGrey ();
			spawnRed ();
			spawnYellow ();

		}
		if (State == 6) {
			//(instantiate code for State here)
			spawnBlue ();
			spawnTeal ();
			spawnRed ();
			spawnPink ();
			spawnOrange ();
			spawnYellow ();

		}
	}

	//yOU WIN FUNCTION
	void YouWin ()
	{
		Debug.Log ("Congrats you win");
		OverallGameManagerErik.PuzzleWon (this.gameObject);
	}

	//YOU LOSE FUNCTION
	void YouLose ()
	{
		//Debug.Log("Failure");
		OverallGameManagerErik.MadeError ();
		isClickedBlue = false;
		isClickedTeal = false;
		isClickedGreen = false;
		isClickedGrey = false;
		isClickedRed = false;
		isClickedPink = false;
		isClickedOrange = false;
		isClickedYellow = false;
		finalizeAnswere = false;

	}


	// Update is called once per frame
	void Update ()
	{
		if (!isLoaded) {
			Model = OverallGameManagerErik.antenna;
			//Debug.Log("Model" + Model);
			isLoaded = true;
		}


		//(Add raycast to check fo the tag of each object and set their state to true here)
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHitInfo = new RaycastHit ();

		//IF THE MOUSE CLICKS OVER AN OBJECT CHECK THE TAG AND ACTIVATE THE OBJECT
		if (Physics.Raycast (ray, out rayHitInfo, 1000f) && (Input.GetMouseButtonDown (0))) {
			if (rayHitInfo.collider.tag == "BlueBox") {
				isClickedBlue = !isClickedBlue;
				StartCoroutine (ChangeBlueButton ());
				Debug.Log ("Blue clicked");
			}
			if (rayHitInfo.collider.tag == "TealBox") {
				isClickedTeal = !isClickedTeal;
				StartCoroutine (ChangePurpleButton ());
				Debug.Log ("Teal clicked");
			}
			if (rayHitInfo.collider.tag == "GreenBox") {
				isClickedGreen = !isClickedGreen;
				StartCoroutine (ChangeGreenButton ());
				Debug.Log ("Green clicked");
			}
			if (rayHitInfo.collider.tag == "GreyBox") {
				isClickedGrey = !isClickedGrey;
				StartCoroutine (ChangeLightBlueButton ());
				Debug.Log ("Grey clicked");
			}
			if (rayHitInfo.collider.tag == "RedBox") {
				isClickedRed = !isClickedRed;
				StartCoroutine (ChangeRedButton ());
				Debug.Log ("Red clicked");
			}
			if (rayHitInfo.collider.tag == "PinkBox") {
				isClickedPink = !isClickedPink;
				StartCoroutine (ChangePinkButton ());
				Debug.Log ("Pink clicked");
			}
			if (rayHitInfo.collider.tag == "OrangeBox") {
				isClickedOrange = !isClickedOrange;
				StartCoroutine (ChangeOrangeButton ());
				Debug.Log ("Orange clicked");
			}
			if (rayHitInfo.collider.tag == "YellowBox") {
				isClickedYellow = !isClickedYellow;
				StartCoroutine (ChangeYellowButton ());
				Debug.Log ("Yellow clicked");
			}

		}

		//=================================================================================================================================
		//ANSWERS AND DECLARING WIN/LOSE FOR EACH GAME STATE
		if (State == 1) {
            
			if (Model == 0 || Model == 1) {
				if (finalizeAnswere == true) {
					if (isClickedPink == true && isClickedGreen == true && isClickedBlue == false && isClickedGrey == false && isClickedOrange == false && isClickedRed == false && isClickedTeal == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			} else if (Model == 2) {
				if (finalizeAnswere == true) {
					if (isClickedTeal == true && isClickedOrange == true && isClickedBlue == false && isClickedGrey == false && isClickedPink == false && isClickedRed == false && isClickedGreen == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			}

		}
		if (State == 2) {

			if (Model == 0 || Model == 1) {
				if (finalizeAnswere == true) {
					if (isClickedOrange == true && isClickedYellow == true && isClickedBlue == false && isClickedTeal == false && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			} else if (Model == 2) {
				if (finalizeAnswere == true) {
					if (isClickedTeal == true && isClickedOrange == true && isClickedBlue == false && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			}

		}
		if (State == 3) {

			if (Model == 0 || Model == 2) {
				if (finalizeAnswere == true) {
					if (isClickedPink == true && isClickedGrey == true && isClickedBlue == false && isClickedTeal == false && isClickedGreen == false && isClickedRed == false && isClickedOrange == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			} else if (Model == 1) {
				if (finalizeAnswere == true) {
					if (isClickedTeal == true && isClickedBlue == true && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false && isClickedOrange == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			}

		}
		if (State == 4) {

			if (Model == 0 || Model == 1) {
				if (finalizeAnswere == true) {
					if (isClickedPink == true && isClickedGreen == true && isClickedBlue == false && isClickedTeal == false && isClickedGrey == false && isClickedRed == false && isClickedOrange == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			} else if (Model == 2) {
				if (finalizeAnswere == true) {
					if (isClickedRed == true && isClickedBlue == true && isClickedTeal == false && isClickedGreen == false && isClickedGrey == false && isClickedPink == false && isClickedOrange == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			}

		}
		if (State == 5) {

			if (Model == 0 || Model == 2) {
				if (finalizeAnswere == true) {
					if (isClickedRed == true && isClickedYellow == true && isClickedBlue == false && isClickedTeal == false && isClickedGreen == false && isClickedGrey == false && isClickedPink == false && isClickedOrange == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			} else if (Model == 1) {
				if (finalizeAnswere == true) {
					if (isClickedTeal == true && isClickedBlue == true && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedOrange == false && isClickedPink == false && isClickedYellow == false) {
						YouWin ();
					} else {
						YouLose ();
					}
				}
			}

		}
		if (State == 6) {

			if (finalizeAnswere == true) {
				if (isClickedTeal == true && isClickedOrange == true && isClickedBlue == false && isClickedGreen == false && isClickedGrey == false && isClickedRed == false && isClickedPink == false && isClickedYellow == false) {
					YouWin ();
				} else {
					YouLose ();
				}
			}
		}

	}

	//==========================================================================================================================================
	//SPAWN BUTTONS BELOW.

	void spawnBlue ()
	{
		GameObject myButton = (GameObject)Instantiate (blueBox, blueBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalBlue = GameObject.Find ("BlueBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnTeal ()
	{
		GameObject myButton = (GameObject)Instantiate (tealBox, tealBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalPurple = GameObject.Find ("TealBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnGreen ()
	{
		GameObject myButton = (GameObject)Instantiate (greenBox, greenBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalGreen = GameObject.Find ("GreenBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnGrey ()
	{
		GameObject myButton = (GameObject)Instantiate (greyBox, greyBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalLightBlue = GameObject.Find ("GreyBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnRed ()
	{
		GameObject myButton = (GameObject)Instantiate (redBox, redBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalRed = GameObject.Find ("RedBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnPink ()
	{
		GameObject myButton = (GameObject)Instantiate (pinkBox, pinkBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalPink = GameObject.Find ("PinkBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnOrange ()
	{
		GameObject myButton = (GameObject)Instantiate (orangeBox, orangeBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalOrange = GameObject.Find ("OrangeBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	void spawnYellow ()
	{
		GameObject myButton = (GameObject)Instantiate (yellowBox, yellowBox.transform.localPosition, gameObject.transform.rotation);
		myButton.transform.parent = transform;
		originalYellow = GameObject.Find ("YellowBox(Clone)").GetComponent<SpriteRenderer> ();
	}

	/// <summary>
	/// Player has hit submit button.
	/// </summary>
	public void FinalAnswer(){
			finalizeAnswere = true;
	}


	//=========================================================================================================================================
	//CHANGE STATES OF BUTTON SPRITES WHEN PRESSED, THEN CHANGE BACK TO ORIGINAL.

	public IEnumerator ChangeBlueButton(){
		originalBlue.sprite = bluePressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalBlue.sprite = blueUp;
	}

	public IEnumerator ChangeLightBlueButton(){
		originalLightBlue.sprite = lightBluePressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalLightBlue.sprite = lightBlueUp;
	}

	public IEnumerator ChangeGreenButton(){
		originalGreen.sprite = greenPressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalGreen.sprite = greenUp;
	}

	public IEnumerator ChangePurpleButton(){
		originalPurple.sprite = purplePressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalPurple.sprite = purpleUp;
	}

	public IEnumerator ChangeRedButton(){
		originalRed.sprite = redPressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalRed.sprite = redUp;
	}

	public IEnumerator ChangePinkButton(){
		originalPink.sprite = pinkPressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalPink.sprite = pinkUp;
	}

	public IEnumerator ChangeYellowButton(){
		originalYellow.sprite = yellowPressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalYellow.sprite = yellowUp;
	}

	public IEnumerator ChangeOrangeButton(){
		originalOrange.sprite = orangePressed;
		soundManager.PlayOneShot (clickSound, 0.7f);
		yield return new WaitForSeconds (0.1f);
		originalOrange.sprite = orangeUp;
	}
}
