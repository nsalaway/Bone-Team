using UnityEngine;
using System.Collections;

public class Robot_Reaction : MonoBehaviour {


	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 0 (hearts)****
	//turned off for testing
//	public GameObject closedRight;
//	public GameObject openRight;


	//materials
	public Material pinkMaterial;
	public Material blackMaterial;
	public Material superPinkMaterial;
	public Material reallySuperPinkMaterial;

	//eye1 hierarchy
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

	//****END OBJECTS FOR EYE 0.****



	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 1 (visor)****

	public GameObject visor;
	public Material winkyFace;
	public Material goodReaction;

	//****END OBJECTS FOR EYE 1.






	// Use this for initialization
	void Start () {


		//these are objects that should be invisible. 
		//commented out for testing purposes. 
//		foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>()) {
//			openRightRenderer.enabled = false;
//		}
//
		//****IF EYE 0 IS CHOSEN:****

		//this replaces the closed right eye with an open right eye. 
		//also turned OFF for testing reasons

//		foreach (MeshRenderer closedLeftRenderer in closedLeft.GetComponentsInChildren<MeshRenderer>()) {
//			closedLeftRenderer.enabled = false;
//		}
//
//		foreach (MeshRenderer openLeftRenderer in openLeft.GetComponentsInChildren<MeshRenderer>()) {
//			openLeftRenderer.enabled = true;
//		}
//
//		//this replaces the closed right eye with an open right eye. 
//		foreach (MeshRenderer openRightRenderer in openRight.GetComponentsInChildren<MeshRenderer>()) {
//			openRightRenderer.enabled = true;
//		}
//
//		foreach (MeshRenderer closedRightRenderer in closedRight.GetComponentsInChildren<MeshRenderer>()) {
//			closedRightRenderer.enabled = false;
//		}


		//this coroutine is in charge of the FIRST POSITIVE REACTION for EYE 0.
		bottomLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		bottomRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		thirdRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		fourthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		fourthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		fifthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
		fifthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

		heartLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
		heartRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

		StartCoroutine (HappyLightDance1 ());

		//****end IF EYE 0 IS CHOSEN



		//****IF EYE 1 IS CHOSEN****


		visor.GetComponent<MeshRenderer> ().material = goodReaction;
		visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (0.02f, -0.12f);
		visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (9.18f, -2.61f);


		StartCoroutine (eye1Animation ());

		//****END IF EYE 1 IS CHOSEN****





	}



	
	// Update is called once per frame
	void Update () {

	
	}



	//ANIMATION IF EYE == 0 
	IEnumerator HappyLightDance1(){
		while (true) {
			yield return new WaitForSeconds (1f);
		

			//layer 1
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

			//layer 2
			yield return new WaitForSeconds (1f);

			bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;


			//layer 3

			yield return new WaitForSeconds (1f);
			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			//layer 4

			yield return new WaitForSeconds (1f);
			bottomLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			//layer 5

			yield return new WaitForSeconds (1f);
			bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;

			fourthLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
			fourthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;

			fifthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
			fifthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;

			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;
		}
			
	}

	//END 



	IEnumerator eye1Animation (){
	
		while (true) {

			visor.GetComponent<MeshRenderer> ().material = winkyFace;
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (30.4f, 3f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.3f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.6f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.9f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.2f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.5f, 0f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.8f, 0f);

		

		
		}
	
	}


}
