using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {


	// Update is called once per frame
	void Update () {	
		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit mouseRayInfo = new RaycastHit ();

		//Using mouse raycast to detect which body part is being touched.
		if(Input.GetMouseButtonDown(0) && Physics.Raycast(mouseRay, out mouseRayInfo, 1000f)){
			GameObject bodyPartTouched = mouseRayInfo.collider.gameObject; //what body part did the player just touch?
			Debug.Log ("You touched " + bodyPartTouched.tag); //print the tag of the body part touched.
		}

		//Detects any key/which key(s) is currently being pressed (except for mouse input since the raycast is handling that).
		//I thought this method might be more convenient since we may be using multiple keys depending on the puzzles.
		if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1)) {
			//do nothing.
		} else if (Input.anyKeyDown) {
			Debug.Log (Input.inputString); //print which key was pressed.
		}
	}
}