using UnityEngine;
using System.Collections;

public class Robot_Reaction : MonoBehaviour {

	//the original eyes vs the new eyes. 

	public GameObject eye1Normal;
	public GameObject eye1Good;


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


	// Use this for initialization
	void Start () {

	

		//this replaces the normal winking eyes with two open eyes and starts a coroutine. 
		foreach (MeshRenderer eye1Renderer in eye1Normal.GetComponentsInChildren<MeshRenderer>()) {
			eye1Renderer.enabled = false;
		}

		foreach (MeshRenderer eye2Renderer in eye1Good.GetComponentsInChildren<MeshRenderer>()) {
			eye2Renderer.enabled = true;
		}



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







		//this sets up the coroutine for a SECOND WIN. 
		//basically, this speeds up the colors and makes them a bit more obnoxious. 
		//everything here has been COMMENTED OUT until it finds it's rightful time to shine. 

//		bottomLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//		bottomRight.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//
//		secondLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//		secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//		thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
//		thirdRight.GetComponent<MeshRenderer> ().material = puperPinkMaterial;
//
//		fourthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//		fourthRight.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//
//		fifthLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//		fifthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//		heartLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
//		heartRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//		StartCoroutine (HappyLightDance2 ());





	}
	
	// Update is called once per frame
	void Update () {

	
	}



	//the 1ST positive reaction 
	IEnumerator HappyLightDance1(){
		while (true) {
			yield return new WaitForSeconds (1f);
			Debug.Log ("Level One: Purgatory");

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
			Debug.Log ("Level Two: Lust");
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
			Debug.Log("Level Three: Anger");
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
			Debug.Log("Level Four: Greed? Money People I think??");
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
			Debug.Log("Level Five: Traitors Maybe idk");
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




	//the 2ND positive reaction 
//	IEnumerator HappyLightDance2(){
//		while (true) {
//			yield return new WaitForSeconds (0.3f);
//			Debug.Log ("Level One: Purgatory");
//
//			//layer 1
//			bottomLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			secondLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			secondRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			fifthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			heartLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
//			heartRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			//layer 2
//			yield return new WaitForSeconds (0.3f);
//			Debug.Log ("Level Two: Lust");
//			bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//			bottomRight.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//
//			secondLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			thirdLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			fourthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//
//			//layer 3
//			Debug.Log("Level Three: Anger");
//			yield return new WaitForSeconds (0.3f);
//			bottomLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			bottomRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			secondLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//			secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			thirdLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			thirdRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			fourthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			fourthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			fifthLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			fifthRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			//layer 4
//			Debug.Log("Level Four: Greed? Money People I think??");
//			yield return new WaitForSeconds (0.3f);
//			bottomLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			bottomRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			secondLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
//			secondRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			thirdLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//			thirdRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			fourthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			fourthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			fifthLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
//			fifthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			//layer 5
//			Debug.Log("Level Five: Traitors Maybe idk");
//			yield return new WaitForSeconds (0.3f);
//			bottomLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//			bottomRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			secondLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			secondRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			thirdLeft.GetComponent<MeshRenderer> ().material = pinkMaterial;
//			thirdRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//
//			fourthLeft.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//			fourthRight.GetComponent<MeshRenderer> ().material = superPinkMaterial;
//
//			fifthLeft.GetComponent<MeshRenderer> ().material = reallySuperPinkMaterial;
//			fifthRight.GetComponent<MeshRenderer> ().material = pinkMaterial;
//
//			heartLeft.GetComponent<MeshRenderer> ().material = blackMaterial;
//			heartRight.GetComponent<MeshRenderer> ().material = blackMaterial;
//		}
//
//	}




}
