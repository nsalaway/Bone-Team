using UnityEngine;
using System.Collections;

public class Second_Negatives : MonoBehaviour {


	//***PUBLIC OBJECTS FOR EYE 0
	//the eyes that must be turned off and on.   
	public GameObject openLeft;
	public GameObject closedLeft;
	public GameObject openRight;
	public GameObject closedRight;


	//materials
	public Material blueMaterial;
	public Material whiteMaterial;
	public Material darkBlue;
	public Material darkerBlue;
	public Material darkestBlue;
	public Material blackMaterial;
	public Material pinkMaterial;

	//eye0 hierarchy
	public GameObject bottomLeft;
	public GameObject bottomRight;

	public GameObject secondLeft;
	public GameObject secondRight;

	public GameObject thirdLeft;
	public GameObject thirdRight;

	public GameObject fourthLeft;
	public GameObject fourthRight;

	public GameObject fifthLeft;
	public GameObject fifthRight;

	public GameObject heartLeft;
	public GameObject heartRight;

	public float duration = 0.2f;

	public MeshRenderer heartRenderer;
	//***END PUBLIC OBJECTS FOR EYE 0




	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 1 (visor)****

	public GameObject visor;
	public Material badReaction;
	public Material superFrownyFace;

	//****END OBJECTS FOR EYE 1.



	//***THE FOLLOWING ARE FOR PUBLIC OBJECTS WITH EYE 2

	public GameObject startX;
	public GameObject otherX;

	public GameObject startO;
	public GameObject otherO;

	public GameObject left1;
	public GameObject left2;
	public GameObject left3;


	public GameObject right1;
	public GameObject right2;
	public GameObject right3;

	// END OBJECTS FOR EYE 2


	// Use this for initialization
	void Start () {

		//these are objects that should be invisible. 
		//commented out for testing purposes. 
		//		foreach (MeshRenderer closedLeftRenderer in openRight.GetComponentsInChildren<MeshRenderer>()) {
		//			closedLeftRenderer.enabled = false;
		//		}


		//IF EYE == 0
		//this replaces the open left eye with an closed left eye for a second.
		//this is to create a grimacing affect.

		foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>()) {
			closedLeftRenderer.enabled = true;
		}

		foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>()) {
			openLeftRenderer.enabled = false;
		}
		foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>()) {
			openRightRenderer.enabled = false;
		}

		foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>()) {
			closedRightRenderer.enabled = true;
		}
		//turns on the coroutine
		StartCoroutine (BlueScreened ());

		//END IF EYE == 0



		//****IF EYE 1 IS CHOSEN****

		visor.GetComponent<MeshRenderer> ().material = badReaction;
		visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0f, -0.03f);
		visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (-9.33f, -2.89f);
		StartCoroutine (eye1Animation ());

		//****END IF EYE 1 IS CHOSEN*******



		//if eye 2 is chosen

		StartCoroutine (eye2Animation ());

		//end if eye 2 is chosen 


	}





	// Update is called once per frame
	void Update () {

	}







	//COROUTINE ANIMATION FOR EYE 0
	IEnumerator BlueScreened(){

		while (true) {
			//this opens eyes again so that we can get obnoxious.
			yield return new WaitForSeconds (1f);
			foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>()) {
				closedLeftRenderer.enabled = false;
			}

			foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>()) {
				openLeftRenderer.enabled = true;
			}

			//this replaces the closed right eye with an open right eye. 
			foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>()) {
				openRightRenderer.enabled = true;
			}

			foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>()) {
				closedRightRenderer.enabled = false;
			}

			//LOL THIS IS ALL THE BLUE SCREEN ANIMATION. 

			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			yield return new WaitForSeconds (0.3f);


			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = whiteMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = whiteMaterial;

			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			heartRight.GetComponent<MeshRenderer> ().material = darkBlue;

			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fourthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			heartRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			thirdRight.GetComponent<MeshRenderer> ().material = darkBlue;

			fourthLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			fourthRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			heartRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			secondRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			thirdLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			thirdRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			secondRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blueMaterial;


			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			yield return new WaitForSeconds (1f);

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (1f);

			heartLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			yield return new WaitForSeconds (1f);

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (3f);
			bottomLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			bottomRight.GetComponent<MeshRenderer> ().material = darkBlue;

			secondLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			secondRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			thirdLeft.GetComponent<MeshRenderer> ().material = darkestBlue;
			thirdRight.GetComponent<MeshRenderer> ().material = darkestBlue;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);
			bottomLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blueMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blueMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = darkBlue;
			fourthRight.GetComponent<MeshRenderer> ().material = darkBlue;

			fifthLeft.GetComponent<MeshRenderer> ().material = darkerBlue;
			fifthRight.GetComponent<MeshRenderer> ().material = darkerBlue;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (0.3f);

			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;

		}

	}

	//END COROUTINE FOR EYE 0





	IEnumerator eye1Animation (){

		while (true) {
			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material = superFrownyFace;

			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0f, -0.2f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (29.66f, 1.5f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.3f, -0.2f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (48.37f, 4.5f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.6f, -0.2f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (95.4f, 7.7f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.9f, -0.2f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (104.5f, 11.3f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (1.2f, -0.2f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (178.13f, 26.4f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (1.5f, -0.2f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (178.13f, 26.4f);


		}

	}



	IEnumerator eye2Animation (){

		while (true) {

			foreach (MeshRenderer otherXRenderer in otherX.GetComponentsInChildren<MeshRenderer>()) {
				otherXRenderer.enabled = true;
			}

			foreach (MeshRenderer startXRenderer in startX.GetComponentsInChildren<MeshRenderer>()) {
				startXRenderer.enabled = true;
			}

			startX.GetComponent<MeshRenderer> ().material = blackMaterial;
			otherX.GetComponent<MeshRenderer> ().material = blackMaterial;

			yield return new WaitForSeconds (2f);

			left1.GetComponent<MeshRenderer> ().material = pinkMaterial;
			right1.GetComponent<MeshRenderer> ().material = pinkMaterial;

			left3.GetComponent<MeshRenderer> ().material = pinkMaterial;
			right3.GetComponent<MeshRenderer> ().material = pinkMaterial;



			yield return new WaitForSeconds (2f);


		}

	}



}
