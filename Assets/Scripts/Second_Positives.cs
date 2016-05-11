using UnityEngine;
using System.Collections;

public class Second_Positives : MonoBehaviour {


	//****the following are public objects for EYE 0****
	//turned off for testing
	//	public GameObject closedRight;
	//	public GameObject openRight;
	//public GameObject closedLeft;
	//public GameObject openLeft;


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

	//****end objects for EYE 0.****


	//****THE FOLLOWING ARE PUBLIC OBJECTS FOR EYE 1 (visor)****

	public GameObject visor;
	public Material goodReaction;
	public Material superWinkyFace;

	//****END OBJECTS FOR EYE 1.


	// Use this for initialization
	void Start () {

//opens eyes if closed before. also commented out for testing. 
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

	
		//this sets up the coroutine for a SECOND WIN. 
		//basically, this speeds up the colors and makes them a bit more obnoxious. 
		//everything here has been COMMENTED OUT until it finds it's rightful time to shine. 

				bottomLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				bottomRight.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
		
				secondLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
		
				thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
				thirdRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
		
				fourthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				fourthRight.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
		
				fifthLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				fifthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
		
				heartLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
				heartRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
		
				StartCoroutine (HappyLightDance2 ());




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


	//the 2ND positive reaction 
		IEnumerator HappyLightDance2(){
			while (true) {
				yield return new WaitForSeconds (0.3f);
				Debug.Log ("Level One: Purgatory");
	
				//layer 1
				bottomLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				fifthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				heartLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
				heartRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				//layer 2
				yield return new WaitForSeconds (0.3f);
				Debug.Log ("Level Two: Lust");
				bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				bottomRight.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
	
				secondLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				fourthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
	
				//layer 3
				Debug.Log("Level Three: Anger");
				yield return new WaitForSeconds (0.3f);
				bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				secondLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				thirdLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				thirdRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				//layer 4
				Debug.Log("Level Four: Greed? Money People I think??");
				yield return new WaitForSeconds (0.3f);
				bottomLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				bottomRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
				secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				thirdLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				thirdRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				fourthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				fourthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				fifthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
				fifthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				//layer 5
				Debug.Log("Level Five: Traitors Maybe idk");
				yield return new WaitForSeconds (0.3f);
				bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				secondLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
				thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;
	
				fourthLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
				fourthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
	
				fifthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
				fifthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
	
				heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
				heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;
			}
	
		}


	//FOR EYE 1 ANIMATIONS
	IEnumerator eye1Animation (){

		while (true) {

			visor.GetComponent<MeshRenderer> ().material = superWinkyFace;

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.3f, 0f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (30.4f, 3f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.6f, 0f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (35.84f, 4.92f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (6.9f, 0f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (54.24f, 8.1f);
			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.2f, 0f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (106.1f, 14.2f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.5f, 0f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (199.6f, 34.6f);

			yield return new WaitForSeconds (0.3f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureOffset = new Vector2 (7.8f, 0f);
			visor.GetComponent<MeshRenderer> ().material.mainTextureScale = new Vector2 (411.2f, 234.1f);




		}

	}



}
